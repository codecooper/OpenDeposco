using System.Net.Http.Headers;
using System.Text;

namespace OpenDeposco;

//TODO: add a method to return a flag if a list has more records (206 response)
public partial class DeposcoService : IDeposcoService
{
    private static protected HttpClient? _httpClient;
    private OpenDeposcoConfig _openDeposcoConfig = new OpenDeposcoConfig();

    public DeposcoService(string username, string password, string code, Uri apiUri) =>
        OpenDeposcoConfig = new OpenDeposcoConfig(username, password, code, apiUri);

    public DeposcoService(OpenDeposcoConfig deposcoConfig) =>
        OpenDeposcoConfig = deposcoConfig;

    public IAddressValidationClient AddressValidation => new AddressValidationClient(_httpClient!) { BaseUrl = _openDeposcoConfig.ApiUri.ToString() };
    public IBulkClient Bulk => new BulkClient(_httpClient!) { BaseUrl = _openDeposcoConfig.ApiUri.ToString() };
    public IUserClient User => new UserClient(_httpClient!) { BaseUrl = _openDeposcoConfig.ApiUri.ToString() };

    public OpenDeposcoConfig OpenDeposcoConfig
    {
        get => _openDeposcoConfig ?? new OpenDeposcoConfig();
        set
        {
            // TODO: Add rate limiting to 10 calls per second.
            _openDeposcoConfig = value;

            // Create and configure the HttpClient
            _httpClient = new HttpClient
            {
                Timeout = _openDeposcoConfig.HttpTimeout
            };

            // Configure Basic Authentication
            var credentials = Convert.ToBase64String(
                Encoding.ASCII.GetBytes($"{_openDeposcoConfig.Username}:{_openDeposcoConfig.Password}")
            );
            //_httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", credentials);
        }
    }
}