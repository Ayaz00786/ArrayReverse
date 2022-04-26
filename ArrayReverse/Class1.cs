using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayReverse
{
    internal class Class1
    {
        public static void Array()
        {
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter number in Position {0}:", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Value Stored in Array Are: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" {0} ", array[i]);
            }

            Console.WriteLine("\n\nReverse Number of Array :");
            for (int i = array.Length-1; i >=0; i--)
            {
                Console.Write(" {0} ",array[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
