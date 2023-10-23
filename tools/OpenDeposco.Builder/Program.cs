using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using OpenDeposco.Builder.Filters;
using System.Net.Mime;
using System.Reflection;
using System.Xml.XPath;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// TODO: Remove this once they have been added to SwaggerGen proper
var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
if (File.Exists(xmlPath))
{
    builder.Services.AddSingleton(new XPathDocument(xmlPath));
}
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo {
        Title = "Depesco API",
        Version = "v1",
        Description = 
            "This document is created and maintained by the community and is designed to be a non-state specific specification. Please refer to your regions documentation for specific details and deviations." +
            "Please keep in mind that there are rate limits and other terms of use enforced by Depesco. This document is only designed to give developers a standard used for code generation and testing."
    });
    c.AddServer(new OpenApiServer { Url = "https://api.deposco.com", Description = "Production environment" });
    c.AddServer(new OpenApiServer { Url = "https://sandboxapi.deposco.com/ua", Description = "UA environment" });

    c.EnableAnnotations(true, true);
    //c.DocumentFilter<AdditionalPropertiesDocumentFilter>();
    c.SchemaFilter<DateTimeSchemaFilter>();
    c.SchemaFilter<DescribeEnumMemberValuesFilter>();
    c.OperationFilter<NullableOperationFilter>();

    c.CustomOperationIds(e => $"{e.ActionDescriptor.RouteValues["action"]}");

    if (File.Exists(xmlPath))
    {
        c.IncludeXmlComments(xmlPath);
    }

    // TODO: Remove this once they have been added to SwaggerGen proper
    //c.AddCustomSwaggerGenFilters();

    // Define the Basic Authentication scheme
    c.AddSecurityDefinition("BasicAuth", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.Http,
        Scheme = "basic",
        Description = "Basic Authentication. Enter your username and password.",
    });

    // Include the Basic Authentication scheme in the UI documentation
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "BasicAuth"
                    }
                },
                new string[] {}
            }
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
