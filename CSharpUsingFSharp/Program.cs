using System;

namespace CSharpUsingFSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToSort = new int[] { 4, 19, 1, 45, 8, 33};
            Array.ForEach(FSharpCode.FSharpSort.sort(arrayToSort), Console.WriteLine);

            Console.ReadKey();
        }
    }
}
