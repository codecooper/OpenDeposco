using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace OpenDeposco.Builder.Controllers;

/// <summary>
/// The Bulk API
/// </summary>
[Route("integration/{code}/bulk")]
[ApiController]
[SwaggerTag("Send a large number of items or orders to Deposco in a single request", "https://doc.deposco.com/docs/html/Content/API/Bulk_API/Bulk_API.htm")]
public class BulkController : ControllerBase
{
    /// <summary>
    /// Use the POST method to send an asynchronous bulk request to create and update multiple items or orders.
    /// </summary>
    /// <remarks>
    /// Each request should include either orders or items, but not both types of entities.
    /// A DocStoreDetail record is created in Deposco for the bulk request.DocStoreResponse records are created for each entity in the request.
    /// </remarks>
    /// <param name="code">Company code for your Deposco environment</param>
    /// <param name="request"></param>
    /// <param name="uniqueToken">Optionally enter your own ID to identify the bulk request. You can then check the status of the request by using the token</param>
    /// <returns></returns>
    [HttpPost("")]
    [Consumes("application/json", "application/xml")]
    [Produces("application/json", "application/xml")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MultiStatus.MultistatusResponse))]
    public IActionResult BulkUpsertItemsOrders([Required, FromBody] BulkUpdate.BulkUpdateCollection request, [Required, FromRoute] string code, [FromQuery] string? uniqueToken) =>
        throw new NotImplementedException();

    /// <summary>
    /// Get the status of a bulk request by request ID
    /// </summary>
    /// <param name="code">Company code for your Deposco environment</param>
    /// <param name="requestID">ID of the bulk request to get the status of. This ID is returned in the href field of the response for the POST request.</param>
    /// <param name="includeSuccessDetails">Set to true to include details for entities that were successfully created or updated. The default value is false, which includes details only for entities that could not be created or updated</param>
    /// <returns></returns>
    [HttpGet("{requestID}/details")]
    [Consumes("application/json", "application/xml")]
    [Produces("application/json", "application/xml")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BulkUpdateResponse.BulkUpdateResponseCollection))]
    public IActionResult GetBulkStatusByRequestId([Required, FromRoute] string code, [Required, FromRoute] string requestID, bool includeSuccessDetails) =>
        throw new NotImplementedException();

    /// <summary>
    /// Get the status of a bulk request by your own unique token
    /// </summary>
    /// <param name="code">Company code for your Deposco environment</param>
    /// <param name="token">If you included a unique token as a query parameter on the POST request, then enter the token.</param>
    /// <param name="includeSuccessDetails">Set to true to include details for entities that were successfully created or updated. The default value is false, which includes details only for entities that could not be created or updated</param>
    /// <returns></returns>
    [HttpGet("uniqueToken/{token}")]
    [Consumes("application/json", "application/xml")]
    [Produces("application/json", "application/xml")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BulkUpdateResponse.BulkUpdateResponseCollection))]
    public IActionResult GetBulkStatusByToken([Required, FromRoute] string code, [Required, FromRoute] string token, bool includeSuccessDetails) =>
        throw new NotImplementedException();
}
