using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OWPFilmoviProjekat.Startup))]
namespace OWPFilmoviProjekat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
