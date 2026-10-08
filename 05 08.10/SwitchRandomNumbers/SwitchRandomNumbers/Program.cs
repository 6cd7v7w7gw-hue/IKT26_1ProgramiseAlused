namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täringu viskamise mäng");

            //Random genereerib iga kord suvalise nr 1st 6ni
            int cube = new Random().Next(1, 7);

            //kasuta switchi ja iga juhtum tuleb ära printida mis number tuli

            switch (cube)
            {
                case 1:
                    Console.WriteLine("Said number 1");
                    break;
                case 2:
                    Console.WriteLine("Said number 2");
                    break;
                case 3:
                    Console.WriteLine("Said number 3");
                    break;
                case 4:
                    Console.WriteLine("Said number 4");
                    break;
                case 5:
                    Console.WriteLine("Said number 5");
                    break;
                case 6:
                    Console.WriteLine("Said number 6");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
