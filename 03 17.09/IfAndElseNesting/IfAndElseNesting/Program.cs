namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");
            int a = 0;
            if (int.TryParse(Console.ReadLine(), out int b))
            {
                a = b;
            }
            if (a == 12)
            {
                Console.WriteLine("a = 12");
            }
            else if (a > 20)
            {
                if (a > 30)
                {
                    Console.WriteLine("a > 30");
                }
                else
                {
                    Console.WriteLine("a > 20 ja < 30");
                }
            }
            else
            {
                Console.WriteLine("minigt kahtlased väärtused");
            }
        }
    }
}