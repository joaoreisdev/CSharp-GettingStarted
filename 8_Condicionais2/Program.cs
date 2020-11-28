using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8!");

            int idadeJoao = 18;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas >= 2;
           

            // || é igual ao operador OU, && é igual ao operar E
            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }

            Console.ReadLine();
        }
    }
}
