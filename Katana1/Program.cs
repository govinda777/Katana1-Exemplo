using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katana1
{
    class Program
    {
        static void Main(string[] args)
        {

            var url = "http://localhost:9999";

            using (WebApp.Start<Startup>(url))
            {
                Console.Write("Servidor iniciado");

                Console.ReadLine();

            }

        }
    }
}
