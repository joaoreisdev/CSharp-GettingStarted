using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3-Criando Variaveis ponto flutuante!");

            double salario = 1200.70;

            double idade = 15.0;

            idade = idade / 2;

            Console.WriteLine(salario);
            
            Console.WriteLine("A execução acabou, tecle enter para sair!");
            Console.WriteLine(idade);

            Console.WriteLine("*-*-*-*-*-**-*-*-*-*-*-");

            double x;
            x = 5 / 3;
            Console.WriteLine("5 / 3 = " + x);

            double y;
            y = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + y);


            Console.ReadLine();
        }
    }
}
