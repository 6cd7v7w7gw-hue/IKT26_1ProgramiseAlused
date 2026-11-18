
namespace YesGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta sõna!");

            string word = Console.ReadLine();

            //while ja nii kaua tsükkel kestab kuni kasutaja sisestab sõna yes

            while (word != "yes")
            {
                Console.Clear();
                Console.WriteLine("Proovi uuesti");
                word = Console.ReadLine();
            }

            Console.WriteLine("Vaga hea sa võitsid");
        }
    }
}
