using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exceutando o projeto 4:");

            double salario;
            salario = 1200.50;


            //Casting - transformações de tipos forçada
            int salarioEmInteiro = (int) salario;

            Console.WriteLine(salario);

            Console.WriteLine(salarioEmInteiro);

            //32bits na memória
            long idade = 13000000000000;
            Console.WriteLine(idade);

            //16bits na memória
            short quantidadeProdutos = 1500;
            Console.WriteLine(quantidadeProdutos);

            //Menos preciso que o Double
            float altura = 1.80f;
            Console.WriteLine(altura);
            
            Console.ReadLine();
        
        }
    }
}
