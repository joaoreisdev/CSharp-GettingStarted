﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(String[] args)
    {
        int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }

        for (int c = 1; c <= 10; c++)
        {
            Console.WriteLine(c);
        }
    
    }
}