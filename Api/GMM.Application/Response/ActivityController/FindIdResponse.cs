using GMM.Application.Models;
using System.Text.Json.Serialization;

namespace GMM.Application.Response.ActivityController
{
    public class FindIdResponse
    {
        public ModelActivity Activity { get; set; }
    }
}
