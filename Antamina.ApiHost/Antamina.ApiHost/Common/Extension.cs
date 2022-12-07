using System.Text.Json.Serialization;
using System.Text.Json;
using Antamina.ApiHost.Entities.DTO;

namespace Antamina.ApiHost.Common
{
    public static class Extension
    {
        public class DateTimeConverter : JsonConverter<DateTime>
        {
            public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                Console.WriteLine(reader.GetString());
                long dateString = Convert.ToInt64(reader.GetString().Replace("/Date(", string.Empty).Replace(")/", string.Empty).Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries)[0]);
                return DateTimeOffset.FromUnixTimeMilliseconds(dateString).DateTime;
            }
            public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
            {
                writer.WriteStringValue(value.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ssZ"));
            }
        }
    }
}
