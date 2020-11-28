using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5");

            //Character, sempre usamos áspas simples para char, o char internamente é representado por um número (Tabela ascii)
            char primeiraLetra = 'a';

            Console.WriteLine("PrimeiraLetra-> " + primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine("PrimeiraLetra-> " + primeiraLetra);

            primeiraLetra = (char)(33);
            Console.WriteLine("PrimeiraLetra-> " + primeiraLetra);

            string titulo = "Alura cursos de tecnologia " + 2020;

            string cursosProgramacao = 
@"- .NET
- Java
- Javascript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();
        }
    }
}
