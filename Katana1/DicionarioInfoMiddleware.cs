using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katana1
{
    public class DicionarioInfoMiddleware : OwinMiddleware
    {
        public DicionarioInfoMiddleware(OwinMiddleware next) : base(next)
        {

        }

        public override async Task Invoke(IOwinContext context)
        {
            foreach(var item in context.Environment)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }

            await Next.Invoke(context);
        }

    }
}
