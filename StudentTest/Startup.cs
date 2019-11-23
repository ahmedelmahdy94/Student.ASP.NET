using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentTest.Startup))]
namespace StudentTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
