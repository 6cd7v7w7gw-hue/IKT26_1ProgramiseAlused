namespace IfAndElse
{
    //Projekt nimitusega IfAndElse, mille sees asub class nimega Progam
    //See klass sisaldab main metoodit, mis on programmi sisenemispunkt
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda nimi :");

            //muutuja nimega name, kuhu salvestatakse kasutaja
            //sisestatud tekst
            string name = Console.ReadLine();

            //! tahendab ei ole ja == tahendab on võrdne
            if (name != "")
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Sisestasid enda nime");
                Console.WriteLine(name);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                
                Console.WriteLine("Error, nime ei sisestanud");
                // kui kasutaja ei sisesta midagi siis koostub 2 piiksu
                Console.Beep();
                // ja oodatakse 1 sekund enne programmi lõppu
                Thread.Sleep(1000);
                Console.Beep();
            }
        }
    }
}
