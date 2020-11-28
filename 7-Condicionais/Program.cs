using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7!");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Possui mais de 18 anos, pode entrar!");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos mas está acompanhado, pode entrar!");
                }
                else
                {
                    Console.WriteLine("Não possui mais de 18 anos não pode entrar!");
                }
            }

            Console.ReadLine();
        }
    }
}
