﻿using GMM.ExternalServices.AwsS3.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.ExternalServices.AwsS3.EndPoint
{
    public class FileAws : IFileAws
    {
        private readonly IApiAwsS3 _apiAwsS3;

        public FileAws(IApiAwsS3 apiAwsS3)
        {
            this._apiAwsS3 = apiAwsS3;
        }

        public Task<bool> DeleteFileS3(string pathFile, string name, string awsAccessKey, string awsSecretKey, string awsSessionToken)
        {
            return _apiAwsS3.DeleteFileS3(pathFile, name, awsAccessKey, awsSecretKey, awsSessionToken);
        }

        public string DownloadFileS3(string pathFile, string awsAccessKey, string awsSecretKey, string awsSessionToken)
        {
            return _apiAwsS3.DownloadFileS3(pathFile, awsAccessKey, awsSecretKey, awsSessionToken);
        }
    }
}
