namespace Trahvid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis oli lubatud kiirus");
            int limit = int.Parse(Console.ReadLine());
            Console.WriteLine("Mis oli teie reaalne kiirus");
            int speed = int.Parse(Console.ReadLine());

            int uletus = speed - limit;

            if (uletus <= 0)
            {
                Console.WriteLine("kõik on hästi");
            }
            else if (uletus <= 10)
            {
                Console.WriteLine("teil on trahv 20 eurot kurat");
            }
            else if (uletus <= 20)
            {
                Console.WriteLine("teil on trahv 50 eurot kurat");
            }
            else if (uletus <= 30)
            {
                Console.WriteLine("teil on trahv 100 eurot kurat");
            }
            else
            {
                Console.WriteLine("teil on trahv 300 eurot ja juhtimisõigus peatatakse");
            }
        }
    }
}
