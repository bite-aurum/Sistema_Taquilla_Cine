using System;

namespace Sistema_Taquilla_Cine
{
    internal class BoletoAdultoMayor : Boleto
    {
        public string Matricula { get; set; }

        public BoletoAdultoMayor(decimal precioBase, string matricula) : base(precioBase)
        {
            Matricula = matricula;
        }
    }
}