using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoogleWebAutoComplete.Startup))]
namespace GoogleWebAutoComplete
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
