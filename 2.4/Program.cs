using System;




namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var minValue = 0;
            var maxValue = 100;
            var number = random.Next(minValue, maxValue);
            var moduleMultiplicity1 = 3;
            var moduleMultiplicity2 = 5;
            var summ = number;

            Console.WriteLine(number);

            for (var i = 0; i < number; i++)
            {
                if (i % moduleMultiplicity1 == 0 || i % moduleMultiplicity2 == 0)
                {
                    summ += i;
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n" + summ);
        }
    }
}
