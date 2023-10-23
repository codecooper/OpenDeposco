namespace OpenDeposco;

public interface IDeposcoService
{
    OpenDeposcoConfig OpenDeposcoConfig { get; set; }
    IAddressValidationClient AddressValidation { get; }
    IBulkClient Bulk { get; }

    IUserClient User { get; }
}