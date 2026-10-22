namespace Kontrolltoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mida tahad teha (1,2,3)");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    Console.WriteLine("Liitmine");
                    Console.WriteLine("Sisesta esimene number");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sisesta teine number");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case "2":
                    Auh();
                    break;
                case "3":
                    Console.WriteLine("Kirjuta sinu nimi :");
                    string name = Console.ReadLine();
                    Console.WriteLine($"Sinu nimi on {name}");
                    break;
                default:
                    Console.WriteLine("Sisestasid muu number provi uuesti");
                    break;
            }
        }

        static void Auh()
        {
            Console.WriteLine("Auh");
        }
    }
}
