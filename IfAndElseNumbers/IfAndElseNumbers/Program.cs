namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");

            //konsoolis sisestame numbri
            //see number salvestatakse string andmetüüpi
            //toimub kontroll, kas sisestatud väärtus on number
            // kasutada if ja else lauseid
            string number = Console.ReadLine()
                                   .Replace('.',',');

            //kontrollime, kas sisestatud väärtus on number
            if (float.TryParse(number, out float num))
            {
                Console.WriteLine("On number");
            }
            else
            {
                Console.WriteLine("Ei ole number");
            }
        }
    }
}
