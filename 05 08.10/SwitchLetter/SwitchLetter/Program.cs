namespace SwitchLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("meetodi valimine");

            //tee kolm meetodit mis teevad järgmist :
            // esimene ütleb auh
            // teine ütleb et tahan magada
            // kolmas ütleb tahan õppida
            // need tulb esile kutsuda numri valikuga

            Console.WriteLine("Tee oma valik");
            Console.WriteLine("1. ütleb auh");
            Console.WriteLine("2. ütleb tahan magada");
            Console.WriteLine("3. ütleb tahan õppida");

            int valik = int.Parse(Console.ReadLine());
            switch (valik)
            {
                case 1:
                    Auh();
                    break;
                case 2:
                    Magada();
                    break;
                case 3:
                    Oppida();
                    break;
                default:
                    Console.WriteLine("Sisestasid vale valik");
                    break;
            }

        }
        static void Auh()
        {
            Console.WriteLine("Auh");
        }
        static void Magada()
        {
            Console.WriteLine("Tahan magada");
        }
        static void Oppida()
        {
            Console.WriteLine("Tahan õppida");
        }
    }
}
