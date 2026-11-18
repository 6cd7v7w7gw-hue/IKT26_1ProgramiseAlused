namespace ForPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //sisestad numbri

            int number = int.Parse(Console.ReadLine());
            bool isPrime = number > 1;


            if (number == 2 || (number > 2 && number % 2 != 0 && !Enumerable.Range(1, ((int)Math.Sqrt(number) - 1) / 2).Any(i => number % (2 * i + 1) == 0)))
            {
                Console.WriteLine("on algarv");
            }
            else
            {
                Console.WriteLine("ei ole algarv");
            }

    }
    }
}
