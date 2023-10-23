using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace OpenDeposco.Builder.Filters;
/*
public class OperationNameFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        if (context.ApiDescription.ActionDescriptor is not ControllerActionDescriptor controllerActionDescriptor)
            return;
        // Set the operation name to the controller method name
        operation.OperationId = controllerActionDescriptor.ActionName;
    }
}*/