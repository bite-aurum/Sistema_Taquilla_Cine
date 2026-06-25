using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Taquilla_Cine
{
    public class BoletoAdultoMayor : Boleto
    {
        public string NumeroInapam { get; set; }

        public BoletoAdultoMayor(decimal precioBase, string numeroInapam) : base(precioBase)
        {
            NumeroInapam = numeroInapam;
        }

        public override decimal CalcularPrecioFinal()
        {
            return PrecioBase * 0.50m;
        }
    }
}
