using System.Threading.Tasks;
using Abp.Application.Services;
using MPAPhoneProject.Authorization.Accounts.Dto;

namespace MPAPhoneProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
