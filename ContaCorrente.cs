using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerInterface
{
    public class ContaCorrente : ITributavel
    {
        public double Saldo { get; set; }

        public ContaCorrente(double saldo)
        {
            this.Saldo = saldo;
        }

        public double CalcularTributos()
        {
            return this.Saldo * 0.05;
        }
    }
}
