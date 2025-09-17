using System.Collections.Immutable;

namespace subm_routines__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = new int[array.Length];
            int value = 1;
            for (int i = 0; i < array.Length; i++) {
                array2 = array.Where((x,j) => j!=i).ToArray();
                foreach (int k in array2) {
                    value *= k;
                }
                Console.WriteLine(value);
                value = 1;
            }
        }
    }
}
