using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katana1
{
    public static class AppBuilderExtensions
    {
        public static void UseOlaMundo(this IAppBuilder app)
        {
            app.Use<OlaMundo>();
        }
    }
}
