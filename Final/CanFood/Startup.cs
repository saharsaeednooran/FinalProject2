using CanFood.Models;
using Microsoft.Owin;
using Owin;
using System.Collections.Generic;

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
