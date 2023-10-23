/*
using Microsoft.OpenApi.Models;
using OpenDeposco.Builder.Data;
using OpenDeposco.Builder.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace OpenDeposco.Builder.Filters;

internal class AdditionalSchemasDocumentFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        context.SchemaGenerator.GenerateSchema(typeof(RefundableState), context.SchemaRepository);
        context.SchemaGenerator.GenerateSchema(typeof(TicketActionType), context.SchemaRepository);
        context.SchemaGenerator.GenerateSchema(typeof(Role), context.SchemaRepository);
        context.SchemaGenerator.GenerateSchema(typeof(TicketStatus), context.SchemaRepository);
        context.SchemaGenerator.GenerateSchema(typeof(TicketType), context.SchemaRepository);
        context.SchemaGenerator.GenerateSchema(typeof(RefundType), context.SchemaRepository);
        context.SchemaGenerator.GenerateSchema(typeof(TicketSource), context.SchemaRepository);
        context.SchemaGenerator.GenerateSchema(typeof(PartialRefundData), context.SchemaRepository);
    }
}
*/