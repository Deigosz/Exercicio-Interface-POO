using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerInterface
{
    public class SeguroVida : ITributavel
    {
        public double CalcularTributos() 
        {
            return 75.0;
        }
    }
}
