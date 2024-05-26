using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerInterface.Interface;

namespace ExerInterface.Services
{
    public class SeguroVida : ITributavel
    {
        public double CalcularTributos()
        {
            return 75.0;
        }
    }
}
