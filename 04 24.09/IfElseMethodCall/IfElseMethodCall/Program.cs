namespace IfElseMethodCall
{
    internal class Program
    {
        // Main on meetod, mis läheb alati esimesena tööle
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("kas soovid meetod kutsuda");
            if (Console.ReadLine() == "jah")
            {
                //kui kirjutan meetodi nime, siis seda nimetatakse
                //meetodi välja kutsumiseks
                HelloMethod();
            }
            else
            {
                Console.WriteLine("siis ei kutse");
            }
        }

        //Teha teine meetod siia ja nimeks on sellel HelloMethod

        static void HelloMethod()
        {
            Console.WriteLine("hello kitty");
        }
    }
}
