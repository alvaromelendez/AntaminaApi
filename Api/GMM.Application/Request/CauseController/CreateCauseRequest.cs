using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Request.CauseController
{
    public class CreateCauseRequest
    {
        public string MaintenanceNotification { get; set; }
        public string MaintenanceNotificationItem { get; set; }
        public string MaintenanceNotificationCause { get; set; }
        public string MaintNotifCauseText { get; set; }
        public string MaintNotifCauseCodeGroup { get; set; }
        public string MaintNotifCauseCodeGroupName { get; set; }
        public string MaintNotificationCauseCode { get; set; }
        public string MaintNotificationCauseCodeName { get; set; }
        public string MaintNotificationRootCause { get; set; }
        public string MaintNotificationRootCauseText { get; set; }
        public string IsDeleted { get; set; }
    }
}
