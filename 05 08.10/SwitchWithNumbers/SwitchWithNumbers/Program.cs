namespace SwitchWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");
            int number = int.Parse(Console.ReadLine());
            // Teie töö on teha switch rakendus
            // kus on kolm case'i
            switch (number)
            {
                case 1:
                    Console.Beep();
                    Console.WriteLine("number on 1");
                    break;
                case 5:
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.Beep();
                    Console.WriteLine("number on 5");
                    break;
                case 10:
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.Beep();
                    Console.WriteLine("number on 10");
                    break;
                default:
                    Console.WriteLine("sisestatud number ei ole 1 5 või 10");
                    break;
            }
        }
    }
}