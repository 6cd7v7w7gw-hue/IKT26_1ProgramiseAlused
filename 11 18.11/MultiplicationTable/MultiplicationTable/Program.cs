namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Korrutustabel");
            int j, i, n;

            Console.WriteLine("Sisesta tabelisse number mis on viimane korrutis");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    Console.Write($"{i} * {j} = {i*j}; ");
                }
                Console.WriteLine("");
            }
        }
    }
}
