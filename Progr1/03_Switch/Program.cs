using System.ComponentModel.Design;

namespace _04_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            int a = int.Parse(b);




            switch (a) {
                case 0:
                  
                    Console.WriteLine("ahoj");
                    break;
                case 1:
                    
                    Console.WriteLine("dneska je úterý");
                    break;
                default:
                    Console.WriteLine("něco");
                    break;
                    
            }
        }
    }
}
