using System.Text.Json.Serialization;
using System.Text.Json;
using Antamina.ApiHost.Entities.DTO;
using System.Xml.Linq;
using System.Xml.Serialization;

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
        public static string GenerateXML(CreateNotificationRequest request)
        {
            XNamespace aw = "http://www.w3.org/2005/Atom";
            XNamespace fc = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata";
            XNamespace fd = "http://schemas.microsoft.com/ado/2007/08/dataservices";
            XElement root = new XElement(aw + "entry",
                new XAttribute("xmlns", "http://www.w3.org/2005/Atom"),
                new XAttribute(XNamespace.Xmlns + "m", "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata"),
                new XAttribute(XNamespace.Xmlns + "d", "http://schemas.microsoft.com/ado/2007/08/dataservices"),
                new XElement(aw + "content",
                    new XAttribute("type", "application/xml"),
                    new XElement(fc + "properties",
                    new XElement(fd + "NotificationText", request.NotificationText),
                    new XElement(fd + "MaintPriority", request.MaintPriority),
                    new XElement(fd + "NotificationType", request.NotificationType),
                    new XElement(fd + "MalfunctionStartDate", request.MalfunctionStartDate),
                    new XElement(fd + "MalfunctionStartTime", request.MalfunctionStartTime),
                    new XElement(fd + "NotificationTimeZone", request.NotificationTimeZone),
                    new XElement(fd + "TechnicalObject", request.TechnicalObject),
                    new XElement(fd + "TechObjIsEquipOrFuncnlLoc", request.TechObjIsEquipOrFuncnlLoc),
                    new XElement(fd + "MaintenanceObjectIsDown", request.MaintenanceObjectIsDown),
                    new XElement(fd + "MainWorkCenter", request.MainWorkCenter),
                    new XElement(fd + "ReportedByUser", request.ReportedByUser)
                    )
                )
            );
            return root.ToString();
        }

        public static T DeserializeResponseXML<T>(string data)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            TextReader reader = new StringReader(data);
            return (T)xmlSerializer.Deserialize(reader);
        }
    }
}
