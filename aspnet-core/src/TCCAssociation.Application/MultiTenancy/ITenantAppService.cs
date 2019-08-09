using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TCCAssociation.MultiTenancy.Dto;

namespace TCCAssociation.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

