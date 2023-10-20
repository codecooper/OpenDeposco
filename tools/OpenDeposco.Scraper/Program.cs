using OpenDeposco.Scraper;

//TODO: Get `code` from either command line or config file
const string code = "";
const string xsdBinPath = "C:\\Program Files (x86)\\Microsoft SDKs\\Windows\\v10.0A\\bin\\NETFX 4.8 Tools\\xsd.exe";
const string pathPrefix = "../../..";

var apiUri = new Uri($"https://{code}-ua.deposco.com/");
var pathToSchemas = Path.Combine(pathPrefix, "schemas.json");
var pathToXsdStatus = Path.Combine(pathPrefix, "xsd_status.json");
var pathToXsds = Path.Combine(pathPrefix, "XSDs/");
var pathToClasses = Path.Combine(pathPrefix, "Models/");
try
{
    Console.WriteLine("Gather Schema List");
    var schemas = LiveDocumentService.GetSchemas(code);

    Console.WriteLine("Saving Schema JSON");
    schemas.SaveToDisk(pathToSchemas);

    using var httpClient = new HttpClient();
    
    foreach (var schema in schemas)
    {
        Console.WriteLine($"Creating {schema.FileName} class");
        await schema.DownloadXsdAsync(httpClient, apiUri, pathToXsds);
    }

    schemas.PopulateNamespaceAndImports(pathToXsds);
    schemas.SaveToDisk(pathToSchemas);
    var xsdStatuses = schemas.CreateClassModels(xsdBinPath, pathToXsds, pathToClasses);

    xsdStatuses.SaveToDisk(pathToXsdStatus);

    Console.WriteLine("Scan Complete!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

