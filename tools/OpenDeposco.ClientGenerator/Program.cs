using NJsonSchema.CodeGeneration.CSharp;
using NSwag;
using NSwag.CodeGeneration.CSharp;
using NSwag.CodeGeneration.OperationNameGenerators;
using System.Text.RegularExpressions;
using System.Web;

var document = OpenApiYamlDocument.FromFileAsync("../../../../../open-deposco.yaml").Result;

var settings = new CSharpClientGeneratorSettings()
{
    ClassName = "{controller}Client",
    ClientBaseClass = "DeposcoClientBase",
    OperationNameGenerator = new MultipleClientsFromFirstTagAndOperationIdGenerator(),
    GenerateClientInterfaces = true,
    GenerateOptionalParameters = true,
    GenerateUpdateJsonSerializerSettingsMethod = false,
    ClientClassAccessModifier = "internal",
    AdditionalNamespaceUsages = new[] { "System.Text.Json" },
    WrapResponses = true,
    //WrapResponseMethods = new[]
    //{
    //    "AnalyticsClient.GetStatisticsByRoleAndDimension",
    //    "AnalyticsClient.GetStatisticsByRoleAndDimensionSummary",
    //    "AnalyticsClient.GetSubscriptionTrends",
    //    "ImagesClient.GetImages",
    //    "OrdersClient.GetOrders",
    //    "Orders2Client.GetOrders",
    //    "ProductsClient.GetProducts",
    //    "ShippingClient.GetShippings",
    //    "Shipping2Client.GetShippings",
    //    "Shipping3Client.GetShippings",
    //    "TicketsClient.GetTickets"
    //},
    ResponseClass = "DeposcoResponse",
    CSharpGeneratorSettings =
    {
        Namespace = "OpenDeposco",
        JsonLibrary = CSharpJsonLibrary.SystemTextJson,
        //GenerateOptionalPropertiesAsNullable = true,
        GenerateNullableReferenceTypes = true,
        GenerateDefaultValues = true,
        GenerateDataAnnotations = true,
        //PropertyNameGenerator = new CustomPropertyNameGenerator(),
        ClassStyle = CSharpClassStyle.Poco,
        DateType = "DateOnly",
        EnumNameGenerator = new CustomEnumNameGenerator()
    }
};

var generator = new CSharpClientGenerator(document, settings);
var code = generator.GenerateFile();
code = code.Replace(
    "[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]",
    string.Empty);

code = Regex.Replace(code, @"namespace OpenDeposco", $@"[assembly: System.Runtime.CompilerServices.InternalsVisibleTo(""OpenDeposco.Tests"")]
namespace OpenDeposco");

code = code.Replace("var result_ = (int)System.Convert.ChangeType(responseData_, typeof(int));",
    "int.TryParse(responseData_, out var result_);");

code = code.Replace($@"throw new ApiException(""No Content"", status_, responseText_, headers_, null);", "return null;");

code = HttpUtility.HtmlDecode(code);

await File.WriteAllTextAsync("../../../../../src/OpenDeposco/DeposcoClient.cs", code);
