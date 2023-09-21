using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    public class Suma : IOperacion
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        // constructor de la clase
        public Suma(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        // implementando método GetOperacion de IOperacion
        public double GetOperacion() => Numero1 + Numero2;
        public override string ToString() => $"{base.ToString()} suma: {GetOperacion():F2}";
    }
}
