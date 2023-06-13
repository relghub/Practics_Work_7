namespace Practics_Work_7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int a, b, c, m, p, q, ind;
            double basic, step;
            a = 1; b = 2; c = 8; m = -7; p = 5; q = 88;
            basic = 3; step = 2.56; ind = 9;
            SquareEquation firstEquation = new(a, b, c);
            SquareEquation secondEquation = new(m, p, q);
            Console.WriteLine("Задача 1\n");
            Console.WriteLine("Перше рівняння:");
            if (firstEquation.RealNumPresence)
            {
                double rootFirst = firstEquation[0];
                Console.WriteLine("Перший корінь становить " +
                                  $"{rootFirst:0.00}.");
                double rootSecond = firstEquation[1];
                Console.WriteLine("Другий корінь становить " +
                                  $"{rootSecond:0.00}.");
            }
            else
            {
                Console.WriteLine("Не має дійсних розв'язків.");
            }
            Console.WriteLine("Друге рівняння:");
            if (secondEquation.RealNumPresence)
            {
                double rootFirst = secondEquation[0];
                Console.WriteLine("Перший корінь становить " +
                                  $"{rootFirst:0.00}.");
                double rootSecond = secondEquation[1];
                Console.WriteLine("Другий корінь становить " +
                                  $"{rootSecond:0.00}.");
            }
            else
            {
                Console.WriteLine("Не має дійсних розв'язків.");
            }
            Console.WriteLine("\nЗадача 2\n");
            GeomProgression number = new(basic, step);
            Console.WriteLine(number[ind]);
        }
    }
}
