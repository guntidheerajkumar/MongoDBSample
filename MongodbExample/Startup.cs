using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MongodbExample.Startup))]
namespace MongodbExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
