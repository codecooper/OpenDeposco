using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenDeposco.Extensions;

namespace OpenDeposco.Converters;

internal class DateTimeOffsetConverter : JsonConverter<DateTimeOffset?>
{
    public override DateTimeOffset? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var simpleDate = reader.TryGetDateTimeOffset(out var dt);
            if(simpleDate)
                return dt;

            var input = reader.GetString();
            if (input == null) return null;
            DateTimeOffset.TryParseExact(input, "yyyyMMddTHHmmsszzz", CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out var notificationDate);
            return notificationDate;
        }

        reader.TrySkip();
        return null;
    }

    public override void Write(Utf8JsonWriter writer, DateTimeOffset? value, JsonSerializerOptions options) =>
        writer.WriteAsNullable(value);
}