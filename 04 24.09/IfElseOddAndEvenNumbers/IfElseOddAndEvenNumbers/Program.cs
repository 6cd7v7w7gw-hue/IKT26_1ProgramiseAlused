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
                    Paariline();
                    // siia tuleb välja kutsuda meetod mis ütleb et see on paarisarv
                }
                else
                {
                    Paaritu();
                }
            }
            else
            {
                Console.WriteLine("see ei ole number");
            }

        }

        static void Paariline()
        {
            Console.WriteLine("number on paaris");
        }
        static void Paaritu()
        {
            Console.WriteLine("number on paaritu");
        }
    }
}
