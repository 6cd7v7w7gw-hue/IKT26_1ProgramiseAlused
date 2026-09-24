namespace IfElseAutod
{
    internal class Program
    {
        //  kasutada if ja else
        //  kirjuta automark 
        //  valikus on BMW, Audi, Porsche, Fiat ja Skoda
        //  kui valitaks skoda, siis seal sees on uusti küsimus et
        //  mis mudelit soovid valida. Mudeli valikus : kodiaq ja octavia
        static void Main(string[] args)
        {
            Console.WriteLine("vali automark");
            Console.WriteLine("valikus on BMW, Audi, Porsche, Fiat ja Skoda");
            Console.WriteLine("");
            string mark = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("valisid " + mark);
            Console.WriteLine("");
            if (mark == "skoda")
            {
                Console.WriteLine("missugune mudel");
                Console.WriteLine("valikus on kodiaq, octavia");
                string mudel = Console.ReadLine();
                Console.WriteLine("");

                if (mudel == "kodiaq")
                {
                    Console.WriteLine("valisid kodiaq");
                }
                else if (mudel == "octavia")
                {
                    Console.WriteLine("valisid octavia");
                }
                else
                {
                    Console.WriteLine("mingi teine mudel");
                }
            }        
        }
    }
}