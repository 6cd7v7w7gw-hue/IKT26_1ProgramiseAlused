namespace ForAsterisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta ridade number : ");

            // tuleb kasutada for loopi
            // sisestan konsooli ridade arvu ja
            // prindib vastabalt ridade arvule tärne
             

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}