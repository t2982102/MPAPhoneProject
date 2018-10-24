using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MPAPhoneProject.MultiTenancy.Dto;

namespace MPAPhoneProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
