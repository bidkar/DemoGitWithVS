using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGitWithVS
{
    class Program
    {
        public string Mensaje { get; set; }

        public Program()
        {
            Mensaje = "Hola UAdeO";
        }

        static void Main(string[] args)
        {
            var saludo = new Program();
            Console.WriteLine(saludo.Mensaje);
            Console.Read();
        }
    }
}
