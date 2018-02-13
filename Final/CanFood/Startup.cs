using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CanFood.Startup))]
namespace CanFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
