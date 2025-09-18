internal class Program {
    static void Main() {
        Console.Write("enter a comma-separated list of numbers\n% ");
        int[] array = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
        int value = 1;
        for (int i = 0; i < array.Length; i++) {
            foreach (int k in array.Where((x,j) => j!=i).ToArray()) {
                value *= k;
            }
            Console.WriteLine($"\x1b[92m{value}");
            value = 1;
        }
        Console.WriteLine("\x1b[0m");
    }
}
