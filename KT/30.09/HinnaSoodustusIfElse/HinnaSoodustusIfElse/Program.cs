namespace HinnaSoodustusIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma ostu summa : ");


            float finalSum = 0;

            if (float.TryParse(Console.ReadLine(), out float sum))
            {

                if (sum < 0)
                {
                    Console.WriteLine("summa ei saa olla vähem kui 0");
                    return;
                }

                Console.WriteLine("Kas teil on klieendikaart");
                bool onKliendiKaart = Console.ReadLine() == "jah";

                if (onKliendiKaart)
                {
                    if (sum >= 100)
                    {
                        finalSum = sum * 0.8f;
                    }
                    else
                    {
                        finalSum = sum * 0.95f;
                    }
                }
                else
                {
                    if (sum > 100)
                    {
                        finalSum = sum * 0.9f;
                    }
                    else
                    {
                        finalSum = sum;
                    }
                }

            }
            else
            {
                Console.WriteLine("Summa ei ole õige");
            }

            Console.WriteLine("Teie finaalne summa on " + finalSum);
        }
    }
}
