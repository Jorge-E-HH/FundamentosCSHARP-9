using FundamentosCSHARP.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace FundamentosCSHARP3.Models
{
    class Vino : Bebida, IBebidaAlcoholica
    {

        public int Alcohol { get; set; }

        public void MaxRecomendado()
        {
            Console.WriteLine("COPAS  permitidas son: 10");
        }

        public Vino(int Cantidad, string Nombre = "Vino")
            : base(Nombre, Cantidad)
        {

        }
    }
    
}


