using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Testando condicionais!");
            int idade = 16;
            int quantidadeDePessoas = 1;

            if(idade >= 18)
            {
                Console.WriteLine("É maior de idade, seja bem vindo!");
            }
            else
            {
                if(quantidadeDePessoas >= 2)
                {
                    Console.WriteLine("É menor de idade mas pode entrar pois está acompanhado");
                }
                else
                {
                    Console.WriteLine("É menor de idade, não pode entrar!");
                }
                
            }

            Console.ReadLine();

        }
    }
}
