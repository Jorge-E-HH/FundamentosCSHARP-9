using System;
using System.Collections.Generic;
using System.Text;
using FundamentosCSHARP.Models;


namespace FundamentosCSHARP3.Models
{
    interface BebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public void MaxRecomendado();
    }
}
