using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            int idade = 0;

            Console.WriteLine("Qual sua idade? ");
            bool sit1 = idade >= 0 && idade <= 15; // não vota
            bool sit2 = idade >= 16 && idade <= 17; // opcional
            bool sit3 = idade >= 18 && idade < 70; // obrigatorio 
            bool sit4 = idade > 70; //opcional

            //resultados
            Console.WriteLine($"");






        }
    }
}
