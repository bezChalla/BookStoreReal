using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookStoreReal.Startup))]
namespace BookStoreReal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
