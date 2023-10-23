namespace OpenDeposco.Tests.Models;

public class ApiKey
{
    private OpenDeposcoConfig _openDeposcoConfig = null!;
    internal DeposcoService DeposcoService = null!;

    public ApiKey(OpenDeposcoConfig openDeposcoConfig)
    {
        DaysToTest = 1;
#if DEBUG
        DaysToTest = 10;
#endif
        OpenDeposcoConfig = openDeposcoConfig;
        if (string.IsNullOrEmpty(openDeposcoConfig.Username)) return;

        //TODO: test if the credentials work
        /*
        try
        {
            var account = DeposcoService.Quickstats.GetQuickstatAccountsAsync().Result;
            Site = account?.AccountData?.First().NickName ??
                   throw new InvalidOperationException("No account is associated with these credentials.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
        */
    }

    public OpenDeposcoConfig OpenDeposcoConfig
    {
        get => _openDeposcoConfig;
        set
        {
            _openDeposcoConfig = value;
            DeposcoService = new DeposcoService( value );
        }
    }

    public int DaysToTest { get; set; }
}
