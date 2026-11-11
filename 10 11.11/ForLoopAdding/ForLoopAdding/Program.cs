namespace ForLoopAdding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("taisarvude kokku liitmine kuni kumneni");

            int j, sum = 0;

            for (j = 1; j <= 10; j++)
            {
                sum += j;

                Console.WriteLine("Summa on: " + sum);
            }
        }
    }
}
