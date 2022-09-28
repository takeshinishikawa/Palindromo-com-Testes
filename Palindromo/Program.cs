using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Palindromo.Model;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("Informe a palavra: ");
                opcao = Console.ReadLine();
                Palindromos word = new ();
                bool resultado = word.IsPalindromo(opcao);
                Console.WriteLine(resultado);
                Console.ReadKey();
                Console.Clear();
                opcao = "";
            } while (opcao == "");
        }
    }
}
