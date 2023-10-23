﻿using NJsonSchema;
using NJsonSchema.CodeGeneration;
using System.Text.RegularExpressions;

public class CustomPropertyNameGenerator : IPropertyNameGenerator
{
    /// <summary>Generates the property name.</summary>
    /// <param name="property">The property.</param>
    /// <returns>The new name.</returns>
    public virtual string Generate(JsonSchemaProperty property)
    {
        var name = ConversionUtilities.ConvertToUpperCamelCase(property.Name
                .Replace("\"", string.Empty)
                .Replace("@", string.Empty)
                .Replace("?", string.Empty)
                .Replace("$", "Dollar")
                .Replace("%", "perc")
                .Replace("[", string.Empty)
                .Replace("]", string.Empty)
                .Replace("(", "_")
                .Replace(")", string.Empty)
                .Replace(".", "-")
                .Replace("=", "-")
                .Replace("+", "plus"), true)
            .Replace("*", "Star")
            .Replace(":", "_")
            .Replace("-", "_")
            .Replace("#", "_");

        if (name.StartsWith("Address", StringComparison.InvariantCultureIgnoreCase))
            return name;
        name = Regex.Replace(name, "[0-9]", "");
        return name;
    }
}

public class CustomEnumNameGenerator : IEnumNameGenerator
{
    public string Generate(int index, string name, object value, JsonSchema schema) =>
        name
            .Replace("/", "_")
            .Replace(".", "_")
            .Replace("-", "_").ToUpper();
}