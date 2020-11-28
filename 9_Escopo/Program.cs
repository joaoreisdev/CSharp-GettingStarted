using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8!");

            int idadeJoao = 18;

            bool acompanhado = true;


            if (acompanhado == true)
            {
               string mensagemAdicional = "João está acompanhado!";
            }
            else
            {
                string mensagemAdicional = "João não está acompanhado";
            }


            // || é igual ao operador OU, && é igual ao operar E
            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar!");
                //Variável só existe dentro do escopo dos ifs
                Console.WriteLine(mensagemAdicional);
            }
            else
                Console.WriteLine("Não pode entrar!");
            

            Console.ReadLine();
        }
    }
}
