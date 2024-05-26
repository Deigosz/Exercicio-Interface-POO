using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerInterface
{
    public class TotalizadorTributos
    {
        public double Total { get; set; }
        public void Adicionar(ITributavel t) 
        {
            this.Total += t.CalcularTributos();
        }
    }
}
