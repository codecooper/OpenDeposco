using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace OpenDeposco.Builder.Filters;

/// <summary>
///     Override the defaults for how swagger makes the file. Since we do not own it, we want to allow additional values.
///     This will be used in Integration Testing.
/// </summary>
public class AdditionalPropertiesDocumentFilter : IDocumentFilter
{
    /// <inheritdoc />
    public void Apply(OpenApiDocument openApiDoc, DocumentFilterContext context)
    {
        foreach (var (schemaName, value) in context.SchemaRepository.Schemas)
        {
            // Check if the schema name ends with "Request"
            if (!schemaName.EndsWith("Request", StringComparison.OrdinalIgnoreCase))
            {
                // Exclude schemas that don't end with "Request"
                value.AdditionalPropertiesAllowed = true;
                value.AdditionalProperties = new OpenApiSchema();
            }
        }
    }
}
