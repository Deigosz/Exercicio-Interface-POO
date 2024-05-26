using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerInterface.Interface;

namespace ExerInterface.Services
{
    public class ContaCorrente : ITributavel
    {
        public double Saldo { get; set; }

        public ContaCorrente(double saldo)
        {
            Saldo = saldo;
        }

        public double CalcularTributos()
        {
            return Saldo * 0.05;
        }
    }
}
