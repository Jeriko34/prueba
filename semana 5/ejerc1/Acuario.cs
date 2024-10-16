using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc1
{
    internal class Acuario
    {
        public string direccion {  get; set; }
        public Delfin Delfin1 { get; set; }
        public Delfin Delfin2 { get; set; }
        public Orca Orca1 { get; set; }

        public void ListaNombre()
        {
            Console.WriteLine($"Delfin1: {Delfin1.Nombre}");
            Console.WriteLine($"Delfin2: {Delfin2.Nombre}");
            Console.WriteLine($"Orca1: {Orca1.Nombre}");
        }
    }
}
