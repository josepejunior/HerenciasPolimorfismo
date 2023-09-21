using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    // declarando interfaz IOperacion
    internal interface IOperacion
    {
        double GetOperacion(); // hacer las respectivas operaciones

        string ToString() => "Resultado de la";// imprime las respectivas operaciones
    }
}
