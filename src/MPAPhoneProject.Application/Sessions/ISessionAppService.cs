using System.Threading.Tasks;
using Abp.Application.Services;
using MPAPhoneProject.Sessions.Dto;

namespace MPAPhoneProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
