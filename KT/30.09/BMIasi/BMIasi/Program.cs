namespace BMIasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BMI = kaal / pikkus^2

            Console.WriteLine("Sisesta oma kaalu (kg) :");
            float kaal = float.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta oma pikkus (M)");
            float pikkus = float.Parse(Console.ReadLine().Replace(".",","));


            float BMI = kaal / (pikkus * pikkus);
            
            if (BMI <= 18.5)
            {
                Console.WriteLine("Teil on alakaal");
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                Console.WriteLine("Teil on normaalkaal");
            }
            else if (BMI >= 25.0 && BMI <= 29.9)
            {
                Console.WriteLine("Teil on ülekaal");
            }
            else
            {
                Console.WriteLine("Olete paks");
            }
        }
    }
}
