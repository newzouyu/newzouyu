using System.Threading.Tasks;
using Abp.Application.Services;
using MyAbpProject6.Sessions.Dto;

namespace MyAbpProject6.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
