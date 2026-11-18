namespace WhileGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Random random = new Random();

            int secret = random.Next(0, 101);
            int guess = 0;
            int attempts = 0;

            while (guess != secret)
            {
                attempts++;
                Console.WriteLine("Kirjuta oma guess : ");
                guess = int.Parse(Console.ReadLine());

                if (guess > secret)
                {
                    Console.WriteLine("liiga suur");
                }
                else if(guess != secret)
                {
                    Console.WriteLine("liiga vaike");
                }

            }

            Console.WriteLine($"Sa võitsid! Number oli {secret}, ja proovinud {attempts} korda");
        }
    }
}
