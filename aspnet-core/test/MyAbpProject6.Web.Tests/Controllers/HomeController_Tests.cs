using System.Threading.Tasks;
using MyAbpProject6.Models.TokenAuth;
using MyAbpProject6.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyAbpProject6.Web.Tests.Controllers
{
    public class HomeController_Tests: MyAbpProject6WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}