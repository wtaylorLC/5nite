using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_5NiteFilms.Startup))]
namespace _5NiteFilms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
