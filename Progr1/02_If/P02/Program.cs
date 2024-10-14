namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Zadejte operátor (*, /, +, -): ");
            string cislo = Console.ReadLine();
            Console.Write("Zadej číslo y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double vysledek = 0;
            if (cislo == "*")
            {
                vysledek = x * y;
            }
            if (cislo == "/")
            {
                vysledek = x / y;
            }
            if (cislo == "+")
            {
                vysledek = x + y;
            }
            if (cislo == "-")
            {
                vysledek = x - y;
            }
            Console.WriteLine("Výsledek: " + vysledek);

        }
    }
}


    

