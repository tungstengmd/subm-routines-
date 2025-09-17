internal class Program {
    static void Main() {
        Console.Write("enter a comma-separated list of numbers\n$ ");
        string[] arr = Console.ReadLine()!.Split(",");  
        int[] array = Array.ConvertAll(arr, int.Parse);
        int[] array2 = new int[array.Length];
        int value = 1;
        for (int i = 0; i < array.Length; i++) {
            array2 = array.Where((x,j) => j!=i).ToArray();
            foreach (int k in array2) {
                value *= k;
            }
            Console.WriteLine($"\x1b[92m{value}");
            value = 1;
        }
        Console.WriteLine("\x1b[0m");
    }
}