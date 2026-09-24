namespace IfElseColour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vali värv");
            Console.WriteLine("valikud on : red, blue, green, white");
            //kirjuta konsoolis
            string color = Console.ReadLine();

            // see kontrollib kas on punane värv
            // kui kasutad if ja else siis esimene kontroll on if
            // ja jargneb else if ning koige viimane on alati else
            if (color == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == "blue")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (color == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (color == "white")
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("vale värv");
                return;
            }
            Console.WriteLine("teie värv on " + color);
        }
    }
}