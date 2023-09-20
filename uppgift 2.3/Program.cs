using System;
namespace uppgift_2_3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur länge ska du hyra bilen?");
            double Hyra = double.Parse(Console.ReadLine());
            Console.WriteLine("Hur¨många kilometer ska du köra?");
            double kilometer = double.Parse(Console.ReadLine());

            double hyraSumma = 300 + (Hyra - 1) * 500;
            double kmSumma = kilometer * 1;

            double totalaSumma = hyraSumma + kmSumma;
            Console.WriteLine("Det kommer kosta dig " + totalaSumma + "kr.");
            Console.ReadKey();

        }
    }
}