using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tcgConsumer.Startup))]
namespace tcgConsumer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
