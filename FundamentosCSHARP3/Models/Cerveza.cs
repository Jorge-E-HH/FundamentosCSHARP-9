using FundamentosCSHARP3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{

    class Cerveza : Bebida, IBebidaAlcoholica
    {

        public int Alcohol { get; set; }
        
        public string Marca { get; set; }
        
        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo permitido son: 4");
        }

        public Cerveza(int Cantidad,string Nombre="Cerveza") 
            : base(Nombre, Cantidad)
        {

        }      
    }

    internal interface IBebidaAlcoholica
    {
        void MaxRecomendado();
    }
}
