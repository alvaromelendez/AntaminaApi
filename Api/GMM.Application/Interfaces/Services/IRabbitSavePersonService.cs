using GMM.Application.Models;

namespace GMM.Application.Interfaces.Services
{
    public interface IRabbitSavePersonService
    {
        void AddPerson(ModelPerson model);
    }
}
