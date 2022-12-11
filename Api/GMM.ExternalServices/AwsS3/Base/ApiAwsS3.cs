using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using System;
using System.IO;
using System.Threading.Tasks;

namespace GMM.ExternalServices.AwsS3.Base
{
    public class ApiAwsS3 : IApiAwsS3
    {
        private readonly AwsS3AntaminaOptions _awsS3Options;
        public ApiAwsS3(AwsS3AntaminaOptions awsS3Options) 
        {
            this._awsS3Options = awsS3Options;
        }

        public async Task<bool> DeleteFileS3(string pathFile, string name, string awsAccessKey, string awsSecretKey, string awsSessionToken)
        {
            var amazonS3Config = new AmazonS3Config { ServiceURL = _awsS3Options.AwsRegionEndPointS3 };
            using (var client = new AmazonS3Client(
                awsAccessKey,
                awsSecretKey,
                awsSessionToken,
                amazonS3Config))
            {
                var request = new DeleteObjectRequest
                {
                    BucketName = _awsS3Options.AwsBucketName,
                    Key = $"{pathFile}/{name}"
                };
                await client.DeleteObjectAsync(request);
                return true;
            }
        }

        public string DownloadFileS3(string pathFile, string awsAccessKey, string awsSecretKey, string awsSessionToken)
        {
            var key = $"{pathFile}";
            string urlIng;
            var amazonS3Config = new AmazonS3Config { ServiceURL = _awsS3Options.AwsRegionEndPointS3 };
            using (IAmazonS3 client = new AmazonS3Client(
                awsAccessKey,
                awsSecretKey,
                awsSessionToken,
                amazonS3Config))
            {
                urlIng = client.GeneratePreSignedURL(_awsS3Options.AwsBucketName, key,
                    DateTime.Now.AddDays(_awsS3Options.AwsDayExpire), null);
            }

            return urlIng;
        }
    }
}
