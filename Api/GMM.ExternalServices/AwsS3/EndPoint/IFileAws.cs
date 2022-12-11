using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.ExternalServices.AwsS3.EndPoint
{
    public interface IFileAws
    {
        Task<bool> DeleteFileS3(string pathFile, string name, string awsAccessKey, string awsSecretKey, string awsSessionToken);
        string DownloadFileS3(string pathFile, string awsAccessKey, string awsSecretKey, string awsSessionToken);
    }
}
