using System.Threading.Tasks;
using Abp.Application.Services;
using MyAbpProject6.Authorization.Accounts.Dto;

namespace MyAbpProject6.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
