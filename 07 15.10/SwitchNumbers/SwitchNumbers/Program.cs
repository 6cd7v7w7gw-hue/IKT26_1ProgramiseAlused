namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 10:
                    Console.WriteLine("sisestasid 10");
                    break;
                case 20:
                    Console.WriteLine("sisestasid 20");
                    break;
                case 30:
                    Console.WriteLine("sisestasid 30");
                    break; 
                default:
                    Console.WriteLine("mingi muu number" + input);
                    break;
            }
        }
    }
}
