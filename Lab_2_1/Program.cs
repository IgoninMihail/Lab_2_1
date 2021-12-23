using System;

namespace Lab_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("введите x");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("введите y");
                double y = double.Parse(Console.ReadLine());
                if (x >= -1 && x <= 1 && x + y >= -1 && x + y <= 0 && y >= -1) Console.WriteLine("да");
                else Console.WriteLine("нет");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
