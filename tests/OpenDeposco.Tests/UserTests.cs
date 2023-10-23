using OpenDeposco.Tests.Fixtures;
using OpenDeposco.Tests.Helpers;
using OpenDeposco.Tests.Models;
using Xunit;
using Xunit.Abstractions;

namespace OpenDeposco.Tests;

[TestCaseOrderer("OpenDeposco.Tests.Fixtures.PriorityOrderer", "OpenDeposco.Tests")]
[Collection("UserTests")]
public class UserTests : IClassFixture<SharedFixture>
{
    private SharedFixture Fixture { get; }
    public OpenDeposcoConfig OpenDeposcoConfig { get; }

    private readonly ITestOutputHelper _testOutputHelper;
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly UserMockClient _badRequestMockClient;
    private readonly UserMockClient _okEmptyMockClient;
    private readonly UserMockClient _okInvalidJsonMockClient;

    public UserTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        Fixture = sharedFixture;
        OpenDeposcoConfig = sharedFixture.ApiKey.OpenDeposcoConfig;
        _testOutputHelper = testOutputHelper;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
        _badRequestMockClient = new UserMockClient(sharedFixture.BadRequestMockHttpClient);
        _okEmptyMockClient = new UserMockClient(sharedFixture.OkEmptyMockHttpClient);
        _okInvalidJsonMockClient = new UserMockClient(sharedFixture.OkInvalidJsonMockHttpClient);
    }

    [SkippableFact]
    public async Task GetUsersAsync_ReturnsUsersWhenAuthorized_ShouldPass()
    {
        var users = await Fixture.ApiKey.DeposcoService.User.GetUsersAsync(OpenDeposcoConfig.Code);
        _additionalPropertiesHelper.CheckAdditionalProperties(users, OpenDeposcoConfig.Username);
        foreach (var user in users.Result.User)
        {
            _additionalPropertiesHelper.CheckAdditionalProperties(user, OpenDeposcoConfig.Username);
        }
    }

    [SkippableFact]
    public async Task GetUserAsync_ReturnsUserWhenAuthorized_ShouldPass()
    {
        var user = await Fixture.ApiKey.DeposcoService.User.GetUserAsync(OpenDeposcoConfig.Code, OpenDeposcoConfig.Username);
        Skip.If(user == null, "No results returned. Unable to test.");
        _additionalPropertiesHelper.CheckAdditionalProperties(user, Fixture.ApiKey.OpenDeposcoConfig.Username);
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

internal class UserMockClient : UserClient, IMockTests
{
    public UserMockClient(HttpClient httpClient) : base(httpClient) => BaseUrl = "https://localhost";

    public void ObjectResponseResult_CanReadText()
    {
        var obj = new ObjectResponseResult<ApiException>(default!, string.Empty);
        Assert.Equal(obj.Text, string.Empty);
    }

    public async Task TestAllMethodsThatReturnDataAsync()
    {
        ReadResponseAsString = true;
        await Assert.ThrowsAsync<ApiException>(async () => await GetUserAsync(string.Empty, string.Empty, CancellationToken.None));
        await Assert.ThrowsAsync<ApiException>(async () => await GetUsersAsync(string.Empty, CancellationToken.None));
        await Assert.ThrowsAsync<ApiException>(async () => await UpdateUserAsync(string.Empty, new UserType(), CancellationToken.None));
        await Assert.ThrowsAsync<ApiException>(async () => await CreateUserAsync(string.Empty, new UserType(), CancellationToken.None));

        ReadResponseAsString = false;
        //Only one method needs to be tested with `ReadResponseAsString = false`
        await Assert.ThrowsAsync<ApiException>(async () => await GetUsersAsync(string.Empty, cancellationToken: CancellationToken.None));
    }
}
