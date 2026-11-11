namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //teha for loopiga lõputu tsükkel

            for (int i = 0; i > -1; i++)
            {
                Console.WriteLine(i);

                if (i == 2)
                    break;
            }
        }
    }
}
