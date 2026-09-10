namespace IfAndElseNesting2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 30;

            if (number > 5)
            {
                if (number == 6)
                {
                    Console.WriteLine("number on 6");
                }
                else if (number >= 12)
                {
                    if (number == 30)
                    {
                        Console.WriteLine("number on 30");
                    }
                    else
                    {
                        Console.WriteLine("number on suurem kui 12");
                    }
                }
                else
                {
                    Console.WriteLine("number on suurem kui 5");
                }
            }
            else if (number == 3)
            {
                Console.WriteLine("number on 3");
            }
            else
            {
                Console.WriteLine("number on väiksem kui 5 ja ei ole 3");
            }
        }
    }
}
