namespace Lab2
{
    class Programm
    {
        static void Main(string [] args)
        {
            Console.WriteLine("последовательно введите e, x: ");
            int e = Convert.ToInt32(Console.ReadLine());
            int x = Convert.ToInt32(Console.ReadLine());
            if(x == 0)
            {
                while(x==0)
                {
                    Console.WriteLine("x не может быть 0. Введите x правильно.");
                    x = Convert.ToInt32(Console.ReadLine());
                }
            }
            int k = 1;
            int counter = 1;
            double rez = 0;
            while(true)
            {
                double n = 1 / k * Math.Pow(x, k);
                k += 2;
                rez += n;
                Console.WriteLine($"{counter} член последовательности = {n}");
                counter += 1;
                if (n < e)
                {
                    break;
                }
            }
            Console.WriteLine($"результат суммирования членов последовательности = {rez}");
        }
    }
}