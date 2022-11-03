namespace ConsoleApp11
{
    internal static class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите необходимый вам разделитель");
            var separator = Console.ReadLine();
            var array = new int[10];
            Random random = new Random();            
            for ( int i = 0; i < array.Length;i++ ) {
                array[i] = random.Next(0, 1000);
            }
            Console.WriteLine(array.SetSeparatorAndShowArray(x => x, separator));
        }

        private static string SetSeparatorAndShowArray<S, T>(this IEnumerable<S> array, Func<S, T> selector, 
            string separator = ", ")
        {
            return string.Join(separator, array.Select(selector));        
        }
    }
}