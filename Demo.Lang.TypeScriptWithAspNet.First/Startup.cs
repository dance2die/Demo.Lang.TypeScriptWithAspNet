using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo.Lang.TypeScriptWithAspNet.First.Startup))]
namespace Demo.Lang.TypeScriptWithAspNet.First
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
