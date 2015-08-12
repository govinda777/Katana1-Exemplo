using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katana1
{
    public class OlaMundo : OwinMiddleware
    {
        private const string _streamResposta = "owin.ResponseBody";
        private const string _headersResposta = "owin.ResponseHeaders";

        public OlaMundo(OwinMiddleware next): base(next)
        {
        }
        
        public override Task Invoke(IOwinContext context)
        {
            context.Response.ContentType = "text/plain; charset=UTF-8";
            return context.Response.WriteAsync("Ola mundo");
        }
    }
}
