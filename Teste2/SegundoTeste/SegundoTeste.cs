using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste2.SegundoTeste
{
    internal class SegundoTeste
    {
        static void VerificarLetraA(string input)
        {
            int contador = 0;

            foreach (char c in input.ToLower())
            {
                if (c == 'a') contador++;
            }

            if (contador > 0)
                Console.WriteLine($"A letra 'A' aparece {contador} vezes.");
            else
                Console.WriteLine("A letra 'A' não aparece na string.");
        }
    }
}
