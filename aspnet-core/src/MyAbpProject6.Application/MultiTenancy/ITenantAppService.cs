using Abp.Application.Services;
using MyAbpProject6.MultiTenancy.Dto;

namespace MyAbpProject6.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

