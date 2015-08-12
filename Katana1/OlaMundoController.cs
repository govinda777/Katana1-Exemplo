using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Katana1
{
    public class OlaMundoController : ApiController
    {
        public MsgBoasVindas Get()
        {
            return new MsgBoasVindas { Data = DateTime.Now, Msg = "Olá, mundo" };
        }
    }

    public class MsgBoasVindas {
        public string Msg { get; set; }
        public DateTime Data { get; set; }
    }
}
