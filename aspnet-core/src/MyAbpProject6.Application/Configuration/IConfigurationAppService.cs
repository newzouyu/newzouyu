using System.Threading.Tasks;
using MyAbpProject6.Configuration.Dto;

namespace MyAbpProject6.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
