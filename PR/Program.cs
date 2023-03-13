using System;

namespace PR
{
    class Program
    {
        public class River
        {
            string Name { get; set; }
            double Squarepool { get; set; }
            double Length { get; set; }

            public River(string name, double squarepool, double lenght)
            {
                Name = name;
                Squarepool = squarepool;
                Length = lenght;
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка статуса");
        }
    }
}
