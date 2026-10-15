namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number!");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("0 kuni 100");
                    break;

                case >= 101 and <= 200:
                    Console.WriteLine("101 kuni 200");
                    break;

                case >= 201 and <= 300:
                    Console.WriteLine("201 kuni 300");
                    break;

                default:
                    Console.WriteLine("mingi muu number " + input);
                    break;
            }
        }
    }
}
