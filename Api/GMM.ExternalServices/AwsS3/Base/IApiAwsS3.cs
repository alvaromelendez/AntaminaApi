
namespace GMM.ExternalServices.AwsS3.Base
{
    public interface IApiAwsS3
    {
        Task<bool> DeleteFileS3(string pathFile, string name, string awsAccessKey, string awsSecretKey, string awsSessionToken);
        string DownloadFileS3(string pathFile, string awsAccessKey, string awsSecretKey, string awsSessionToken);
    }
}
