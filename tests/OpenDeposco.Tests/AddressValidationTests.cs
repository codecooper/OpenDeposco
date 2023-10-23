using OpenDeposco.Tests.Fixtures;
using OpenDeposco.Tests.Helpers;
using System.Xml.Serialization;
using Xunit.Abstractions;

namespace OpenDeposco.Tests;

[TestCaseOrderer("OpenDeposco.Tests.Fixtures.PriorityOrderer", "OpenDeposco.Tests")]
[Collection("AddressValidationTests")]
public class AddressValidationTests : IClassFixture<SharedFixture>
{
    private SharedFixture Fixture { get; }
    public OpenDeposcoConfig OpenDeposcoConfig { get; }

    private readonly ITestOutputHelper _testOutputHelper;
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly AddressValidationMockClient _badRequestMockClient;
    private readonly AddressValidationMockClient _okEmptyMockClient;
    private readonly AddressValidationMockClient _okInvalidJsonMockClient;

    public AddressValidationTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        Fixture = sharedFixture;
        OpenDeposcoConfig = sharedFixture.ApiKey.OpenDeposcoConfig;
        _testOutputHelper = testOutputHelper;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
        _badRequestMockClient = new AddressValidationMockClient(sharedFixture.BadRequestMockHttpClient);
        _okEmptyMockClient = new AddressValidationMockClient(sharedFixture.OkEmptyMockHttpClient);
        _okInvalidJsonMockClient = new AddressValidationMockClient(sharedFixture.OkInvalidJsonMockHttpClient);
    }

    [SkippableFact]
    public async Task GetAddressValidationsAsync_ReturnsAddressValidationsWhenAuthorized_ShouldPass()
    {
        var request = new AddressValidationRequest() { 
            BusinessUnit = "ABC",
            Address = new AddressType() { AddressLine1 = "123 MAIN STREET", City = "ANYTOWN", StateProvinceCode = "TX", PostalCode = "12345-6789", CountryCode = "US" },
            AddressValidationOptions = new AddressValidationOptionsType() { Carrier = "UPS", ProfileName = "Default" }
        };
        var xmlOverride = new XmlAttributeOverrides();
        xmlOverride.Add(typeof(OpenDeposco.AddressType), new XmlAttributes() { XmlIgnore = true });
        var xmlSerializer = new XmlSerializer(typeof(AddressValidationRequest), xmlOverride);
        using var stringWriter = new StringWriter();
        xmlSerializer.Serialize(stringWriter, request);
        string xmlRequest = stringWriter.ToString();

       

        var addressValidationResponse = await Fixture.ApiKey.DeposcoService.AddressValidation.ValidateAddressAsync(OpenDeposcoConfig.Code, xmlRequest, CancellationToken.None );
        _additionalPropertiesHelper.CheckAdditionalProperties(addressValidationResponse, OpenDeposcoConfig.Username);
        foreach (var suggestedAddress in addressValidationResponse.Result?.SuggestedAddresses)
        {
            _additionalPropertiesHelper.CheckAdditionalProperties(suggestedAddress, OpenDeposcoConfig.Username);
        }
    }

    [SkippableFact]
    public async Task BadRequestResponsesAsync() => await _badRequestMockClient.TestAllMethodsThatReturnDataAsync();

    [SkippableFact]
    public async Task OkEmptyResponsesAsync() => await _okEmptyMockClient.TestAllMethodsThatReturnDataAsync();

    [SkippableFact]
    public async Task OkInvalidJsonResponsesAsync() => await _okInvalidJsonMockClient.TestAllMethodsThatReturnDataAsync();

    [SkippableFact]
    public void ObjectResponseResult_CanReadText() => _okEmptyMockClient.ObjectResponseResult_CanReadText();
}

internal class AddressValidationMockClient : AddressValidationClient, IMockTests
{
    public AddressValidationMockClient(HttpClient httpClient) : base(httpClient) => BaseUrl = "https://localhost";

    public void ObjectResponseResult_CanReadText()
    {
        var obj = new ObjectResponseResult<ApiException>(default!, string.Empty);
        Assert.Equal(obj.Text, string.Empty);
    }

    public async Task TestAllMethodsThatReturnDataAsync()
    {
        ReadResponseAsString = true;
        await Assert.ThrowsAsync<ApiException>(async () => await ValidateAddressAsync(string.Empty, string.Empty, CancellationToken.None));

        ReadResponseAsString = false;
        //Only one method needs to be tested with `ReadResponseAsString = false`
        await Assert.ThrowsAsync<ApiException>(async () => await ValidateAddressAsync(string.Empty, string.Empty, CancellationToken.None));
    }
}
