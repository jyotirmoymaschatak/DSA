﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFG_half_diamond_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for(int j=0; j<n-i-1; j++)
                    Console.Write(" ");
                
                for(int j=0; j<(2*i+1) ; j++)
                    Console.Write("*");
                
                for(int j=0; j<n-i-1; j++)
                    Console.Write(" ");
                
                Console.WriteLine();
            }
        }
    }
}
