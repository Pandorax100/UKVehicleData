using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.JsonConverters
{
    /// <summary>
    /// Converts the date format dd/MM/yyyy to JSON.
    /// </summary>
    internal class DayMonthYearDateConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();

            return DateTime.ParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
