using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.JsonConverters
{
    /// <summary>
    /// Converts the date format yyyy-MM to JSON.
    /// </summary>
    internal class YearMonthDateConverter : JsonConverter<DateTime?>
    {
        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();

            return value is null ? null : DateTime.ParseExact(value, "yyyy-MM", CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
