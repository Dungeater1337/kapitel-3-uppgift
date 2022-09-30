using System; 
namespace Uppgift3_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder >= 16 && ålder <= 20)
            {
                Console.WriteLine("Du får vara med och tävla");
            }

            else 
            {
                Console.WriteLine("Du är får inte vara med"); 
            }

            

            
        }
    }
}



