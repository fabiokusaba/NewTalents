using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        public int somar(int val1, int val2)
        {
            return val1 + val2;
        }

        public int subtrair(int val1, int val2)
        {
            return val1 - val2;
        }

        public int multiplicar(int val1, int val2)
        {
            return val1 * val2;
        }

        public int dividir(int val1, int val2)
        {
            return 0;
        }

        public List<string> historico()
        {
            return new List<string>();
        }
    }
}
