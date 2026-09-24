namespace IfElseOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number :");
            //konsool küsib numbrit
            //number tuleb ära parsida
            //if ja else juures toimub kontroll
            string input = Console.ReadLine();

            if (float.TryParse(input, out float num))
            {
                
                if (float.IsInteger(num / 2))
                {
                    Console.WriteLine("number on paaris");
                }
                else
                {
                    Console.WriteLine("number on paaritu");
                }
            }
            else
            {
                Console.WriteLine("see ei ole number");
            }

        }
    }
}
