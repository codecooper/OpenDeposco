using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Net;

namespace OpenDeposco.Builder.Filters;

/*
/// <summary>
/// The possible error codes for each endpoint
/// </summary>
public class ErrorResponsesFilter : IOperationFilter
{
    /// <inheritdoc />
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        operation.Responses.Add(HttpStatusCode.BadRequest.ToString(), new OpenApiResponse
        {
            Description = "Bad Request - The request was incorrect, and the entity could not be created or updated."
        });
        operation.Responses.Add(HttpStatusCode.Conflict.ToString(), new OpenApiResponse
        {
            Description = "Conflict - There was a conflict associated with processing the request, and the entity could not be created or updated."
        });
        operation.Responses.Add(HttpStatusCode.TooManyRequests.ToString(), new OpenApiResponse
        {
            Description = "Too Many Requests - The request was not accepted because the application has exceeded the rate limit."
        });
        operation.Responses.Add(HttpStatusCode.InternalServerError.ToString(), new OpenApiResponse
        {
            Description = "Internal Server Error - An unexpected error occurred, and the request could not be processed."
        });
    }
}
*/