using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerInterface.Interface;

namespace ExerInterface.Services
{
    public class TotalizadorTributos
    {
        public double Total { get; set; }
        public void Adicionar(ITributavel t)
        {
            Total += t.CalcularTributos();
        }
    }
}
