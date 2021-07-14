using Abp.Application.Services;
using VU.IMS.MultiTenancy.Dto;

namespace VU.IMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

