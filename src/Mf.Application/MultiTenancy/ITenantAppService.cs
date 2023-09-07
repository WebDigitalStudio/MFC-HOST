using Abp.Application.Services;
using Mf.MultiTenancy.Dto;

namespace Mf.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

