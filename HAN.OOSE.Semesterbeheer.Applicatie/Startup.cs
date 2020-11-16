using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HAN.OOSE.Semesterbeheer.Applicatie.Startup))]

namespace HAN.OOSE.Semesterbeheer.Applicatie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
