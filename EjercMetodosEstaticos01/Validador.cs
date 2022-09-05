using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercMetodosEstaticos01
{
    public class Validador
    {

        public static bool Validar(int valor, int minimo, int maximo)
        {
            bool retorno = false;
            if(valor>minimo && valor<maximo)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
