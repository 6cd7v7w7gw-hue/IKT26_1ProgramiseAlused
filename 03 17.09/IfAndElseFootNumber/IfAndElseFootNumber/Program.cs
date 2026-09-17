namespace IfAndElseFootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jalanumber");

            int jn = 0;

            if (int.TryParse(Console.ReadLine(), out int b))
            {
                jn = b;
            }

            if (jn >= 30 && jn <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jalanumber on 30 kuni 33");
            }
            else if (jn >= 34 && jn <= 38)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Jalanumber on 34 kuni 38");
            }
            else if (jn >= 39 && jn <= 44)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Jalanumber on 39 kuni 44");
            }
            else if (jn >= 45 && jn <= 48)
            {
                Console.WriteLine("Jalanumber on 45 kuni 48");
                Console.Beep();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Sinu jalanumber on liiga suur voi vaike");
            }
        }
    }
}
