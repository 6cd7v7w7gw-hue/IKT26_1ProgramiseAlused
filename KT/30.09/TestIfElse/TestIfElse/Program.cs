namespace TestIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta username: ");
            string user = Console.ReadLine();
            Console.WriteLine("Sisesta parool: ");
            string pass= Console.ReadLine();

            if (user == "kasutaja")
            {
                if (pass == "123456")
                {
                    Console.WriteLine("tere tulemast");
                }
                else
                {
                    Console.WriteLine("Vale parool");
                }
            }
            else
            {
                Console.WriteLine("Vale kasutaja nimi");
            }

        }
    }
}
