using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {9,6,5,4,3,3,2}; 

            Random random = new Random();

            int qwe = 0;

            for (int i = 0; i < array.Length; i++) 
            {
               qwe = qwe + array[i];
            }
            Console.WriteLine(qwe);


        }
    }
}
