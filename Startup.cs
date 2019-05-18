using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bookstore.Startup))]
namespace bookstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
