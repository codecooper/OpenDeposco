using System.Text.Json.Serialization;

namespace OpenDeposco;

public class OpenDeposcoConfig
{
    public OpenDeposcoConfig()
    {
        Username = string.Empty;
        Password = string.Empty;
        Code = string.Empty;
        ApiUri = new Uri("https://api.deposco.com");
        HttpTimeout = TimeSpan.FromMinutes(3);
    }

    public OpenDeposcoConfig(string username, string password, string code, Uri apiUri)
    {
        Username = username;
        Password = password;
        Code = code;
        ApiUri = apiUri;
        HttpTimeout = TimeSpan.FromMinutes(3);
    }

    public OpenDeposcoConfig(string username, string password, string code, Uri apiUri, TimeSpan httpTimeoutTimeSpan)
    {
        Username = username;
        Password = password;
        Code = code;
        ApiUri = apiUri;
        HttpTimeout = httpTimeoutTimeSpan;
    }

    public OpenDeposcoConfig(string username, string password, string code, Uri apiUri, int httpTimeoutSeconds = 180)
    {
        Username = username;
        Password = password;
        Code = code;
        ApiUri = apiUri;
        HttpTimeout = httpTimeoutSeconds <= 0
            ? new TimeSpan(0, 0, 0, 0, Timeout.Infinite)
            : TimeSpan.FromSeconds(httpTimeoutSeconds);
    }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("password")] public string Password { get; set; }

    [JsonPropertyName("code")] public string Code { get; set; }

    [JsonPropertyName("api_uri")] public Uri ApiUri { get; set; }

    [JsonPropertyName("http_timeout_seconds")]
    public TimeSpan HttpTimeout { get; set; }
}