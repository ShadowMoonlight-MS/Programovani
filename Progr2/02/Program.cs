namespace P_02
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            if (int.TryParse(a, out int b)){
                Console.WriteLine("je číslo: "+ b);
            }
            else
            {
                Console.WriteLine("není číslo");
            }

        }

    }
}
