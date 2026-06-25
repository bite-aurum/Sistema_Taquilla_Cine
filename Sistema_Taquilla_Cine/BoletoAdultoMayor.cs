using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Taquilla_Cine
{
    internal class BoletoAdultoMayor
    {
        public string Matricula { get; set; }
        public float Precio { get; set; }

        public BoletoAdultoMayor(decimal precioBase, string matricula) : base(precioBase)
        {
            Matricula = matricula;
        }

      

    }
}

