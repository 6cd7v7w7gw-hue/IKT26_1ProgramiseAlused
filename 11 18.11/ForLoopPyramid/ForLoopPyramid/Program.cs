namespace ForLoopPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kui suur on vaja seda teha");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i <= amount; i++)
            {
                for (int j = 1;  j <= amount - i; j++)
                    Console.Write(" ");

                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.Write("\n");
            }

            for (int i = amount - 1; i >= 0; i--)
            {
                for (int j = 1; j <= amount - i; j++)
                    Console.Write(" ");

                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.Write("\n");
            }



        }
    }
}
