using System;
namespace Lessons
{
    internal class Program
    {
        static void outputArray(ref int[] ArrayConsole, int i)
        {
            if (i == ArrayConsole.Length)
                return;
            Console.WriteLine(ArrayConsole[i]);
            i++;
            outputArray(ref ArrayConsole, i);
        }
        static void Main(string[] args)
        {
            int[] myArray = new int[5] { 1, 2, 33, 4, 5 };
            outputArray(ref myArray, 0);
        }
    }
}