using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.ExternalServices.Mail.Models
{
    public class MailNotificationResponse
    {
        public int NumRespuesta { get; set; }
        public int CodigoError { get; set; }
        public string MsgRespuesta { get; set; }
        public string Status { get; set; }
    }
}
