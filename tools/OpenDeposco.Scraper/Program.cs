using System.ComponentModel;
using CommandLine;
using OpenDeposco.Scraper;

//TODO: Get `code` from either command line or config file
const string xsdBinPath = "C:\\Program Files (x86)\\Microsoft SDKs\\Windows\\v10.0A\\bin\\NETFX 4.8 Tools\\xsd.exe";
//const string pathPrefix = "../../..";
const string pathPrefix = "";

var code = string.Empty;

CommandLine.Parser.Default.ParseArguments<Options>(args)
            .WithParsed<Options>(options =>
            {
                // Access the 'code' argument from the options object.
                code = options.Code;
            })
            .WithNotParsed(errors =>
            {
                // Handle parsing errors if any.
                Console.WriteLine("Error parsing command-line arguments.");
                Environment.Exit(1);
            });

var apiUri = new Uri($"https://{code}-ua.deposco.com/");
var pathToSchemas = Path.Combine(pathPrefix, "schemas.json");
var pathToXsdStatus = Path.Combine(pathPrefix, "xsd_status.json");
var pathToXsds = Path.Combine(pathPrefix, "XSDs");
var pathToXmlConfigs = Path.Combine(pathPrefix, "XMLConfigs");
var pathToClasses = Path.Combine(pathPrefix, "../../../OpenDeposco.Domain");
try
{
    Console.WriteLine("Gather Schema List");
    var schemas = LiveDocumentService.GetSchemas(code);

    Console.WriteLine("Saving Schema JSON");
    schemas.SaveToDisk(pathToSchemas);

    using var httpClient = new HttpClient();
    
    foreach (var schema in schemas)
    {
        Console.WriteLine($"Downloading {schema.FileName}");
        //await schema.DownloadXsdAsync(httpClient, apiUri, pathToXsds);
        //schema.GenerateClasses(pathToXsds);
    }

    schemas.PopulateNamespaceAndImports(pathToXsds);
    schemas.SaveToDisk(pathToSchemas);
    Console.WriteLine("Creating class models");
    //var xsdStatuses = XsdService.CreateClassModelsFromConfig(xsdBinPath, pathToXmlConfigs, pathToClasses);
    //xsdStatuses.SaveToDisk(pathToXsdStatus);

    //foreach (var xsdStatus in xsdStatuses )
    //{
    //    if(string.IsNullOrEmpty(xsdStatus.Error))
    //        continue;
    //
    //    Console.WriteLine($"ERROR: see {pathToXsdStatus} for details");
    //    Environment.Exit(1);
    //}
    schemas.GenerateClassesUsingXscGen(pathToXsds, pathToClasses);

    Console.WriteLine("Scan Complete!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Environment.Exit(1);
}

