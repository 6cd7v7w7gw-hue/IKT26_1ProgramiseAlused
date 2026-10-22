namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmnurk");

            Console.WriteLine("Sisesta kui suur on vaja seda teha");
            int amount = int.Parse(Console.ReadLine());


            int i = 0;
            while (i < amount)
            {
                int k = amount - i - 1;
                int h = 0;

                while (k > 0)
                {
                    Console.Write(" ");
                    k--;
                }

                while (h < i * 2 + 1)
                {
                    Console.Write("*");
                    h++;
                }

                Console.WriteLine();
                i++;
            }
        }
    }
}
