namespace ForKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("killkoll asi");
            Console.WriteLine();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("see on rida nr {0}", i);
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
