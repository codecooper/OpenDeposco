using OpenDeposco.Scraper.Models;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using XmlSchemaClassGenerator;

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
    
    static internal List<XsdStatus> CreateClassModelsFromConfig (string xsdBinPath, string xmlConfigDirectory, string outputDirectory)
    {
        var xmlFiles = Directory.GetFiles(xmlConfigDirectory, "*.xml");
        var statuses = new List<XsdStatus>();
        foreach (string xmlFile in xmlFiles)
        {
            string arguments = $"/c /p:{xmlFile} /o:{outputDirectory}";
            var status = RunXsdCommand(xsdBinPath, arguments, xmlConfigDirectory);
            statuses.Add(status);
        }
        return statuses;
    }

    private static XsdStatus RunXsdCommand(string xsdBinPath, string aguments, string workingDirectory)
    {
        var process = new Process();
        var startInfo = new ProcessStartInfo
        {
            FileName = xsdBinPath,
            Arguments = aguments,
            //WorkingDirectory = workingDirectory,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            CreateNoWindow = true
        };

        process.StartInfo = startInfo;
        process.Start();

        // Read and print the output if needed
        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();

        process.WaitForExit();
        return new XsdStatus(string.Empty, aguments, output, error);
    }
    /*
    private static XsdStatus CreateClassModelForNamespace(this List<Schema> schemas, string @namespace, string xsdBinPath, string sourceDirectory, string outputDirectory)
    {

    }*/
    /*
    public static void AddSchemas(this OpenApiDocument openApiDocument, List<Schema> schemas, string sourceDirectory)
    {
        // Load the XSD schema
        var xmlSchemas = new XmlSchemas();
        foreach (var schema in schemas)
        {
            var xsdFilePath = Path.Combine(sourceDirectory, schema.FileName);
            var x = new XmlSchema
            {
                SourceUri = xsdFilePath
            };
            xmlSchemas.Add(x);
        }

        // Create an XmlSchemaImporter and XmlCodeExporter
        var schemaImporter = new XmlSchemaImporter(xmlSchemas);
        foreach (XmlSchemaObject item in xmlSchemas)
        {
            if (item is XmlSchemaElement element)
            {
                XmlQualifiedName name = new XmlQualifiedName(element.Name, x.TargetNamespace);
                XmlTypeMapping map = schemaImporter.ImportTypeMapping(name);
                exporter.ExportTypeMapping(map);
            }
        }
    }
    */
    public static void GenerateClasses(this Schema schema, string sourceDirectory)
    {
        var xsdFilePath = Path.Combine(sourceDirectory, schema.FileName);

        // Create an XmlSchemaSet to hold the schema(s).
        var schemaSet = new XmlSchemaSet();

        // Add the XSD file to the schema set.
        schemaSet.Add(null, xsdFilePath);

        // Compile the schema set to check for validation errors (optional).
        schemaSet.Compile();

        var xmlSchema = new XmlSchema();


        foreach (XmlSchema s in schemaSet.Schemas())
        {
            xmlSchema = s;
            break; // Assuming you have only one schema in the XSD file.
        }

        //var importer = new XmlSchemaImporter(xmlSchemas);

        //var codeCompileUnit = new CodeCompileUnit();
        //var options = CodeGenerationOptions.None;
        //XmlCodeExporter exporter = new XmlCodeExporter(code, codeCompileUnit, options);

        foreach (var item in xmlSchema.Items)
        {
            if (item is XmlSchemaElement element)
            {
                var name = new XmlQualifiedName(element.Name, xmlSchema.TargetNamespace);
                //var map = importer.ImportTypeMapping(name);
                //Console.WriteLine(map.ElementName);
                //exporter.ExportTypeMapping(map);
            }
        }
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

    public static void GenerateClassesUsingXscGen(this List<Schema> schemas, string sourceDirectory, string outputDirectory)
    {
        var files = new List<string>();
        foreach (var schema in schemas)
        {
            files.Add(Path.Combine(sourceDirectory, schema.FileName));
        }

        var namespaceMappings = new Dictionary<NamespaceKey, string>
        {
            { new NamespaceKey("http://integration.deposco.com/addressvalidation"), "AddressValidation" },
            { new NamespaceKey("http://integration.deposco.com/billabletransaction"), "BillableTransaction" },
            { new NamespaceKey("http://integration.deposco.com/billabletransactionconfig"), "BillableTransactionConfig" },
            { new NamespaceKey("http://integration.deposco.com/billinginvoice"), "BillingInvoice" },
            { new NamespaceKey("http://integration.deposco.com/billinginvoiceline"), "BillingInvoiceLine" },
            { new NamespaceKey("http://integration.deposco.com/bulkUpdate"), "BulkUpdate" },
            { new NamespaceKey("http://integration.deposco.com/bulkUpdateResponse"), "BulkUpdateResponse" },
            { new NamespaceKey("http://integration.deposco.com/channellisting"), "ChannelListing" },
            { new NamespaceKey("http://integration.deposco.com/channellookup"), "ChannelLookup" },
            { new NamespaceKey("http://integration.deposco.com/cochargeallowance"), "CoChargeAllowance" },
            { new NamespaceKey("http://integration.deposco.com/cocontact"), "CoContact" },
            { new NamespaceKey("http://integration.deposco.com/codate"), "CoDate" },
            { new NamespaceKey("http://integration.deposco.com/coheader"), "CoHeader" },
            { new NamespaceKey("http://integration.deposco.com/coline"), "CoLine" },
            { new NamespaceKey("http://integration.deposco.com/colineallocation"), "CoLineAllocation" },
            { new NamespaceKey("http://integration.deposco.com/colinesite"), "CoLineSite" },
            { new NamespaceKey("http://integration.deposco.com/coManagementProfile"), "CoManagementProfile" },
            { new NamespaceKey("http://integration.deposco.com/company"), "Company" },
            { new NamespaceKey("http://integration.deposco.com/conotice"), "CoNotice" },
            { new NamespaceKey("http://integration.deposco.com/container"), "Container" },
            { new NamespaceKey("http://integration.deposco.com/conveyorscanrequest"), "ConveyorScanRequest" },
            { new NamespaceKey("http://integration.deposco.com/conveyorscanresponse"), "ConveyorScanResponse" },
            { new NamespaceKey("http://integration.deposco.com/copayment"), "CoPayment" },
            { new NamespaceKey("http://integration.deposco.com/copaymentterm"), "CoPaymentTerm" },
            { new NamespaceKey("http://integration.deposco.com/coreference"), "CoReference" },
            { new NamespaceKey("http://integration.deposco.com/corefund"), "CoRefund" },
            { new NamespaceKey("http://integration.deposco.com/coretailactivity"), "CoRetailActivity" },
            { new NamespaceKey("http://integration.deposco.com/cotax"), "CoTax" },
            { new NamespaceKey("http://integration.deposco.com/cube"), "Cube" },
            { new NamespaceKey("http://integration.deposco.com/customer"), "Customer" },
            { new NamespaceKey("http://integration.deposco.com/address"), "Address" },
            { new NamespaceKey("http://integration.deposco.com/contactmethod"), "ContactMethod" },
            { new NamespaceKey("http://integration.deposco.com/decisionService"), "DecisionService" },
            { new NamespaceKey("http://integration.deposco.com/entityimage"), "EntityImage" },
            { new NamespaceKey("http://integration.deposco.com/facility"), "Facility" },
            { new NamespaceKey("http://integration.deposco.com/inventory"), "Inventory" },
            { new NamespaceKey("http://integration.deposco.com/gl"), "Gl" },
            { new NamespaceKey("http://integration.deposco.com/invadjustment"), "InvAdjustment" },
            { new NamespaceKey("http://integration.deposco.com/inventorynoticeactivity"), "InventoryNoticeActivity" },
            { new NamespaceKey("http://integration.deposco.com/invoicedQuantityDetail"), "InvoicedQuantityDetail" },
            { new NamespaceKey("http://integration.deposco.com/invoice"), "Invoice" },
            { new NamespaceKey("http://integration.deposco.com/invoiceLine"), "InvoiceLine" },
            { new NamespaceKey("http://integration.deposco.com/invsegmentationplan"), "InvSegmentationPlan" },
            { new NamespaceKey("http://integration.deposco.com/item"), "Item" },
            { new NamespaceKey("http://integration.deposco.com/itemCustomer"), "ItemCustomer" },
            { new NamespaceKey("http://integration.deposco.com/itemprice"), "ItemPrice" },
            { new NamespaceKey("http://integration.deposco.com/itemVendor"), "ItemVendor" },
            { new NamespaceKey("http://integration.deposco.com/kitdetail"), "KitDetail" },
            { new NamespaceKey("http://integration.deposco.com/kitheader"), "KitHeader" },
            { new NamespaceKey("http://integration.deposco.com/line"), "Line" },
            { new NamespaceKey("http://integration.deposco.com/location"), "Location" },
            { new NamespaceKey("http://integration.deposco.com/multistatus"), "MultiStatus" },
            { new NamespaceKey("http://integration.deposco.com/order"), "Order" },
            { new NamespaceKey("http://integration.deposco.com/orderstatus"), "OrderStatus" },
            { new NamespaceKey("http://integration.deposco.com/orderStatusUpdate"), "OrderStatusUpdate" },
            { new NamespaceKey("http://integration.deposco.com/pack"), "Pack" },
            { new NamespaceKey("http://integration.deposco.com/payment"), "Payment" },
            { new NamespaceKey("http://integration.deposco.com/pickconfirm"), "PickConfirm" },
            { new NamespaceKey("http://integration.deposco.com/picktask"), "PickTask" },
            { new NamespaceKey("http://integration.deposco.com/picktaskforstockunit"), "PickTaskForStockUnit" },
            { new NamespaceKey("http://integration.deposco.com/pickwave"), "PickWave" },
            { new NamespaceKey("http://integration.deposco.com/planItem"), "PlanItem" },
            { new NamespaceKey("http://integration.deposco.com/postshipment"), "PostShipment" },
            { new NamespaceKey("http://integration.deposco.com/prepadvice"), "PrepAdvice" },
            { new NamespaceKey("http://integration.deposco.com/prepadvicedetail"), "PrepAdviceDetail" },
            { new NamespaceKey("http://integration.deposco.com/pricelist"), "PriceList" },
            { new NamespaceKey("http://integration.deposco.com/pricelistdetail"), "PricelistDetail" },
            { new NamespaceKey("http://integration.deposco.com/productCategory"), "ProductCategory" },
            { new NamespaceKey("http://integration.deposco.com/putconfirm"), "PutConfirm" },
            { new NamespaceKey("http://integration.deposco.com/receiptadvice"), "ReceiptAdvice" },
            { new NamespaceKey("http://integration.deposco.com/receiptitemadvice"), "ReceiptItemAdvice" },
            { new NamespaceKey("http://integration.deposco.com/receiptline"), "Receiptline" },
            { new NamespaceKey("http://integration.deposco.com/returnLabel"), "ReturnLabel" },
            { new NamespaceKey("http://integration.deposco.com/RoutingResponse"), "RoutingResponse" },
            { new NamespaceKey("http://integration.deposco.com/shipment"), "Shipment" },
            { new NamespaceKey("http://integration.deposco.com/stockunit"), "Stockunit" },
            { new NamespaceKey("http://integration.deposco.com/storage"), "Storage" },
            { new NamespaceKey("http://integration.deposco.com/tradingPartner"), "TradingPartner" },
            { new NamespaceKey("http://integration.deposco.com/tradingPartnerSite"), "TradingPartnerSite" },
            { new NamespaceKey("http://integration.deposco.com/types"), "Types" },
            { new NamespaceKey("http://integration.deposco.com/upc"), "Upc" },
            { new NamespaceKey("http://integration.deposco.com/user"), "User" },
            { new NamespaceKey("http://integration.deposco.com/webhook"), "Webhook" },
            { new NamespaceKey("http://integration.deposco.com/workgroup"), "Workgroup" },
            { new NamespaceKey("http://integration.deposco.com/workorder"), "Workorder" },
            { new NamespaceKey("http://integration.deposco.com/workorderdetail"), "WorkorderDetail" },
            { new NamespaceKey("http://integration.deposco.com/zone"), "Zone" },
        };

        var generator = new Generator
        {
            OutputFolder = outputDirectory,
            Log = s => Console.Out.WriteLine(s),
            GenerateNullables = true,
            NamespaceProvider = namespaceMappings
                .ToNamespaceProvider(new GeneratorConfiguration { NamespacePrefix = "OpenDeposco" }.NamespaceProvider.GenerateNamespace)
        };

        generator.Generate(files);
    }

    static private void GetNamespaceMapping()
    {
        List<string> namespaces = new List<string>
        {
            "http://integration.deposco.com/addressvalidation",
            "http://integration.deposco.com/billabletransaction",
            "http://integration.deposco.com/billabletransactionconfig",
            "http://integration.deposco.com/billinginvoice",
            "http://integration.deposco.com/billinginvoiceline",
            "http://integration.deposco.com/bulkUpdate",
            "http://integration.deposco.com/bulkUpdateResponse",
            "http://integration.deposco.com/channellisting",
            "http://integration.deposco.com/channellookup",
            "http://integration.deposco.com/cochargeallowance",
            "http://integration.deposco.com/cocontact",
            "http://integration.deposco.com/codate",
            "http://integration.deposco.com/coheader",
            "http://integration.deposco.com/coline",
            "http://integration.deposco.com/colineallocation",
            "http://integration.deposco.com/colinesite",
            "http://integration.deposco.com/coManagementProfile",
            "http://integration.deposco.com/company",
            "http://integration.deposco.com/conotice",
            "http://integration.deposco.com/container",
            "http://integration.deposco.com/conveyorscanrequest",
            "http://integration.deposco.com/conveyorscanresponse",
            "http://integration.deposco.com/copayment",
            "http://integration.deposco.com/copaymentterm",
            "http://integration.deposco.com/coreference",
            "http://integration.deposco.com/corefund",
            "http://integration.deposco.com/coretailactivity",
            "http://integration.deposco.com/cotax",
            "http://integration.deposco.com/cube",
            "http://integration.deposco.com/customer",
            "http://integration.deposco.com/address",
            "http://integration.deposco.com/contactmethod",
            "http://integration.deposco.com/decisionService",
            "http://integration.deposco.com/entityimage",
            "http://integration.deposco.com/facility",
            "http://integration.deposco.com/inventory",
            "http://integration.deposco.com/gl",
            "http://integration.deposco.com/invadjustment",
            "http://integration.deposco.com/inventorynoticeactivity",
            "http://integration.deposco.com/invoicedQuantityDetail",
            "http://integration.deposco.com/invoice",
            "http://integration.deposco.com/invoiceLine",
            "http://integration.deposco.com/invsegmentationplan",
            "http://integration.deposco.com/item",
            "http://integration.deposco.com/itemCustomer",
            "http://integration.deposco.com/itemprice",
            "http://integration.deposco.com/itemVendor",
            "http://integration.deposco.com/kitdetail",
            "http://integration.deposco.com/kitheader",
            "http://integration.deposco.com/line",
            "http://integration.deposco.com/location",
            "http://integration.deposco.com/multistatus",
            "http://integration.deposco.com/order",
            "http://integration.deposco.com/orderstatus",
            "http://integration.deposco.com/orderStatusUpdate",
            "http://integration.deposco.com/pack",
            "http://integration.deposco.com/payment",
            "http://integration.deposco.com/pickconfirm",
            "http://integration.deposco.com/picktask",
            "http://integration.deposco.com/picktaskforstockunit",
            "http://integration.deposco.com/pickwave",
            "http://integration.deposco.com/planItem",
            "http://integration.deposco.com/postshipment",
            "http://integration.deposco.com/prepadvice",
            "http://integration.deposco.com/prepadvicedetail",
            "http://integration.deposco.com/pricelist",
            "http://integration.deposco.com/pricelistdetail",
            "http://integration.deposco.com/productCategory",
            "http://integration.deposco.com/putconfirm",
            "http://integration.deposco.com/receiptadvice",
            "http://integration.deposco.com/receiptitemadvice",
            "http://integration.deposco.com/receiptline",
            "http://integration.deposco.com/returnLabel",
            "http://integration.deposco.com/RoutingResponse",
            "http://integration.deposco.com/shipment",
            "http://integration.deposco.com/stockunit",
            "http://integration.deposco.com/storage",
            "http://integration.deposco.com/tradingPartner",
            "http://integration.deposco.com/tradingPartnerSite",
            "http://integration.deposco.com/types",
            "http://integration.deposco.com/upc",
            "http://integration.deposco.com/user",
            "http://integration.deposco.com/webhook",
            "http://integration.deposco.com/workgroup",
            "http://integration.deposco.com/workorder",
            "http://integration.deposco.com/workorderdetail",
            "http://integration.deposco.com/zone",
        };

        List<string> formattedNamespaces = new List<string>();

        foreach (string namespaceUrl in namespaces)
        {
            // Extract the last part as NamespaceName and capitalize the first letter
            string[] parts = namespaceUrl.Split('/');
            string namespaceName = char.ToUpper(parts[parts.Length - 1][0]) + parts[parts.Length - 1].Substring(1);

            // Combine the namespace URL with the capitalized NamespaceName
            string formattedNamespace = $"{{ new NamespaceKey(\"{namespaceUrl}\"), \"{namespaceName}\" }},";
            formattedNamespaces.Add(formattedNamespace);
        }


        foreach (string formattedNamespace in formattedNamespaces)
        {
            Console.WriteLine(formattedNamespace);
        }

    }
}
