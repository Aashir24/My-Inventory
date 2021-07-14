using System.Threading.Tasks;
using VU.IMS.Models.TokenAuth;
using VU.IMS.Web.Controllers;
using Shouldly;
using Xunit;

namespace VU.IMS.Web.Tests.Controllers
{
    public class HomeController_Tests: IMSWebTestBase
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