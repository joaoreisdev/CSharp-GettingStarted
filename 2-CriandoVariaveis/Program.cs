using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
         {
            int idade;
            idade = 13;
            
            Console.WriteLine("Executando projeto 2 - Criando variáveis");
            Console.WriteLine(idade);
            idade = 20 + 5 / 5;
            Console.WriteLine("Sua idade é " + idade);
            Console.WriteLine("Execução finalizada. Tecle enter para sair!");
            Console.ReadLine();
        }

    }
}
