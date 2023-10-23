using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace OpenDeposco.Builder.Controllers;

/// <summary>
/// Enables you to validate a specific address.
/// </summary>
[Route("integration/{code}/addressvalidation")]
[ApiController]
[SwaggerTag("Enables you to validate a specific address", "https://doc.deposco.com/docs/html/Content/API/Address_validation_API.htm")]
public class AddressValidationController : ControllerBase
{
    /// <summary>
    /// The response from the API indicates whether the address is valid or invalid.
    /// </summary>
    /// <remarks>
    /// The address is validated by either UPS or FedEx. If the address is invalid, then a list of suggested addresses is provided.
    /// </remarks>
    /// <param name="request"></param>
    /// <param name="code">Company code for your Deposco environment</param>
    /// <returns></returns>
    [HttpPost("")]
    [Authorize]
    [Consumes("application/xml")]
    [Produces("application/json", "application/xml")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AddressValidation.AddressValidationResponse))]
    public IActionResult ValidateAddress(
        [Required, FromBody] AddressValidation.AddressValidationRequest request,
        [Required, FromRoute] string code
        ) => throw new NotImplementedException();
}