using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Katana1
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use<DicionarioInfoMiddleware>();
            ConfigurarWebApp(app);
            app.UseOlaMundo();
        }

        private void ConfigurarWebApp(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute("Default", "api/{controller}");
            app.UseWebApi(config);
        }
    }
}
