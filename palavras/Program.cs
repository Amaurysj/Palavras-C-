using System;
using System.Linq;

namespace Usando_var
{
    class program
    {
        static void Main(string[] args)
        {
            string[] palavras = { "Macoratti", "Miriam", "Jeferson", "Janice", "Mario"};
            var consulta = from palavra in palavras
                           where palavra[2] == 'r'
                           select palavra;
            foreach ( string p in consulta)
            {
                Console.WriteLine(p);
            }

        }
    }
}
