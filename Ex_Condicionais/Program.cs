using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double valorIR = 0;

            Console.WriteLine("Insira seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            if ((salario >= 1900.0) && (salario <= 2800.0))
            {
                valorIR = (salario * 7.5) / 100;
                Console.WriteLine("Entrei 1");
            }
            if ((salario >= 2800.01) && (salario <= 3751.0))
            {
                valorIR = (salario * 15) / 100;
                Console.WriteLine("Entrei 2");
            }
            if ((salario >= 3751.01) && (salario <= 4664.00))
            {
                valorIR = (salario * 22.5) / 100;
                Console.WriteLine("Entrei 3");
            }
            if ((salario > 4664.01))
            {
                valorIR = (salario * 27.5) / 100;
                Console.WriteLine("Entrei 4");

            }

            Console.WriteLine("Seu IR é de " + valorIR);
            Console.ReadLine();
        }
    }
}
