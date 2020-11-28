using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("O mês é janeiro");
                    break;
                case 2:
                    Console.WriteLine("O mês é fevereiro");
                    break;
                case 3:
                    Console.WriteLine("O mês é março");
                    break;
                case 4:
                    Console.WriteLine("O mês é abril");
                    break;
                case 5:
                    Console.WriteLine("O mês é maio");
                    break;
                case 6:
                    Console.WriteLine("O mês é junho");
                    break;
                case 7:
                    Console.WriteLine("O mês é julho");
                    break;
                case 8:
                    Console.WriteLine("O mês é Agosto");
                    break;
                case 9:
                    Console.WriteLine("O mês é Setembro");
                    break;
                case 10:
                    Console.WriteLine("O mês é Outubro");
                    break;
                case 11:
                    Console.WriteLine("O mês é Novembro");
                    break;
                case 12:
                    Console.WriteLine("O mês é Dezembro");
                    break;
                default:
                    Console.WriteLine("Mês inválido");
                    break;
            }


            Console.ReadLine();
        }
    }
}
