using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace DyCompanyName.DyProjectName.Pages
{
    public class Index_Tests : DyProjectNameWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
