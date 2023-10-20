using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

public interface IDeposcoClient
{
    public IAddressValidationClient AddressValidation { get; set; }
}
