namespace _05_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] doubleArray = { 1.0, 2.0, 3.0, 4.0 };
            String[] stringArray = { "1", "2", "3", "4" };

            Zobraz(intArray);
            Console.WriteLine("");
            Zobraz(doubleArray);
            Console.WriteLine("");
            Zobraz(stringArray);
            
            
        }
        public static void Zobraz<Thing>(Thing[] array)
        {
            foreach (Thing item in array)
            {
                Console.Write(item+ " ");
            }
        }
        



    }
}