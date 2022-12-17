namespace Antamina.ApiHost.Common
{
    public class ApiCredential
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Url { get; set; }
    }
    public class UrlApis
    {
        public string GetNotificationAll { get; set; }
        public string GetNotificationByID { get; set; }
        public string CreateNotification { get; set; }
        public string GetActivity { get; set; }
    }
}
