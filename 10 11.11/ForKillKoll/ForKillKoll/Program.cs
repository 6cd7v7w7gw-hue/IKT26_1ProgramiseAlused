namespace ForKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("killkoll asi");
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j < 2)
                    {
                        Console.WriteLine("kill - koll");
                    }
                    else
                    {
                        Console.WriteLine("killadi - koll");
                    }
                }
            }
        }
    }
}
