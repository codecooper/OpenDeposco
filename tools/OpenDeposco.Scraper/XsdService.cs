using System.Diagnostics;
using System.Xml.Linq;
using OpenDeposco.Scraper.Models;

namespace OpenDeposco.Scraper;
static internal class XsdService
{

    static internal async Task DownloadXsdAsync(this Schema schema, HttpClient httpClient, Uri apiUri, string outputDirectory)
    {
        var uriBuilder = new UriBuilder(apiUri)
        {
            Path = schema.FileLink
        };
        // Define the arguments to invoke xsd.exe.
        var outputFile = Path.Combine(outputDirectory, schema.FileName);
        await DownloadFileAsync(httpClient, uriBuilder.Uri, outputFile);
    }

    private static async Task DownloadFileAsync(HttpClient httpClient, Uri url, string localFilePath)
    {
        using var response = await httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        using var contentStream = await response.Content.ReadAsStreamAsync();
        using var fileStream = File.Create(localFilePath);
        await contentStream.CopyToAsync(fileStream);
    }

    static internal XsdStatus CreateClassModels (this List<Schema> schemas, string xsdBinPath, string sourceDirectory, string outputDirectory)
    {
        var namespaces = schemas.GetNamespaces();
        foreach (var @namespace in namespaces)
        {
            var imports = schemas.GetImports()
        }
        string arguments = $"/c ";
        foreach (var schema in schemas.Take(5))
        {
            var sourcePath = Path.Combine(sourceDirectory, schema.FileName);
            arguments += $" \"{sourcePath}\" ";
        }
        arguments += $" /o:\"{outputDirectory}\" ";

        // Start the process to run xsd.exe.
        Process process = new();
        process.StartInfo.FileName = xsdBinPath;
        process.StartInfo.Arguments = arguments;
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true;
        process.StartInfo.CreateNoWindow = true;

        // Start the process.
        process.Start();
        process.WaitForExit();

        // Handle the output or errors if needed.
        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();
        return new XsdStatus(string.Empty, arguments, output, error);
    }

    private static XsdStatus CreateClassModelForNamespace(this List<Schema> schemas, string @namespace, string xsdBinPath, string sourceDirectory, string outputDirectory)
    {

    }

    private static HashSet<string> GetNamespaces (this List<Schema> schemas)
    {
        var namespaces = new HashSet<string>();
        foreach (var schema in schemas)
        {
            namespaces.Add(schema.NameSpace);
        }
        return namespaces;
    }

    private static HashSet<string> GetImports(this List<Schema> schemas, string @namespace)
    {
        var imports = new HashSet<string>();
        foreach (var schema in schemas.Where(s => s.NameSpace == @namespace))
        {
            foreach (var import in schema.Imports.Where(i => !string.IsNullOrEmpty(i)))
            {
                imports.Add(import!);
            }
        }
        return imports;
    }

    static internal void PopulateNamespaceAndImports(this List<Schema> schemas, string sourceDirectory)
    {
        foreach (var schema in schemas)
        {
            string xsdFilePath = Path.Combine(sourceDirectory, schema.FileName);

            if (!File.Exists(xsdFilePath))
                throw new FileNotFoundException(xsdFilePath);
            
            // Load the XSD file as an XML document
            var xsdDocument = XDocument.Load(xsdFilePath);

            // Update the Namespace property
            schema.NameSpace = xsdDocument.Root?.Attribute("targetNamespace")?.Value;

            // Update the Imports property
            schema.Imports = xsdDocument.Descendants()
                .Where(e => e.Name.LocalName == "import" && e.Attribute("namespace") != null)
                .Select(e => e.Attribute("namespace")?.Value)
                .ToList();
        }
    }
}
