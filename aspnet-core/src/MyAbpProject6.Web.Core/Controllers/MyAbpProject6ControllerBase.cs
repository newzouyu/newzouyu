using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyAbpProject6.Controllers
{
    public abstract class MyAbpProject6ControllerBase: AbpController
    {
        protected MyAbpProject6ControllerBase()
        {
            LocalizationSourceName = MyAbpProject6Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
