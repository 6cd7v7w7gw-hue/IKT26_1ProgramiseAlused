namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // string e tahemarkide jada mis on defineeritud andemetuubiga string
            // andmetuup toetab ainult true ja falsi vaartusi
            // myString on muutuja, mis on defineeritud andmetuubiga string
            // saab sisestada koike mis on klaviatuuril
            string myString = "Hello, World234!";
            // kirjutage cw ja vajutage tab et genereerida console.writeline
            Console.WriteLine(myString);
            string one = "1";
            string two = "2";
            Console.WriteLine(one + two);
            Console.WriteLine("----- taisavud ------");
            //int on taisarvuline andmetuub mis toetab ainult taisarve
            int myInt = 5;
            int secondInt = 10;
            Console.WriteLine(myInt);
            // kui kaks int tuupi muutujat liita, siis liidetakse nende vaartused kokku
            Console.WriteLine(myInt + secondInt);

            Console.WriteLine("----Bool----");
            // see on andmetuup mis toetab ainult true or false vaartusi

            bool myBool = false;
            Console.WriteLine(myBool);

            Console.WriteLine("----- ujukomaarvud -----");
            //double on ujukommaarvuline andmetuup, mis toetab ainult ujukommaarve
            double myDouble = 5.5;
            double secondDouble = 10.5;

            // kui kaks double tuupi muutujat liita siis liidetakse nende vaartused kokku
            Console.WriteLine(myDouble + secondDouble);

            Console.WriteLine("------ float -------");
            //float on ujukkomaarvuline andmetuup mis toetab ainult ujukommaarve
            float myFloat = 5.5f;
            float secondFloat = 10.5f;
            Console.WriteLine(myFloat);
            Console.WriteLine(myFloat + secondFloat);

            Console.WriteLine("-----decimal-----");
            decimal myDecimal = 5.52m;
            decimal secondDecimal = 10.5m;
            Console.WriteLine(myDecimal);
            Console.WriteLine(myDecimal + secondDecimal);


            Console.WriteLine("------Byte------");
            //byte on taisarvuline andmetuup mis toetab ainult taisarve vahemikus 0 kuni 255
            // see on 8bitine andmetuup
            byte myByte = 5;
            Console.WriteLine(myByte);

            Console.WriteLine("----- long -----");
            //long on taisarvuline andmetuup mis toetab ainult taisarve
            // see on 64 bitine andmetuup
            long myLong = 5L;
            long secondLong = 10L;
            Console.WriteLine(myLong);
            Console.WriteLine(myLong + secondLong);

            Console.WriteLine("---- short ----");
            // short on taisarvuline andmetuup mis toetab ainult taisarve
            // selle maksimaalne vaartus on 32767
            // see on 16biting andmetuup
            short myShort = 5;
            short secondShort = 10;
            Console.WriteLine(myShort);
            Console.WriteLine(myShort + secondShort);
        }
    }
}
