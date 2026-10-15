namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number : ");
            float numOne = float.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta teine number : ");
            float numTwo = float.Parse(Console.ReadLine());


            Console.WriteLine("Mida tahad teha (*, /, -, +)");
            string action = Console.ReadLine();

            switch (action)
            {
                case "*":
                    Console.WriteLine(numOne * numTwo);
                    break;
                case "/":
                    if (numTwo != 0)
                    {
                        Console.WriteLine(numOne / numTwo);
                    }
                    else
                    {
                        Console.WriteLine("ei saa jagada nulliga");
                    }
                    break;
                case "-":
                    Console.WriteLine(numOne - numTwo);
                    break;
                case "+":
                    Console.WriteLine(numOne + numTwo);
                    break;
                default:
                    Console.WriteLine("kathlane tegevus");
                    break;
            }

        }
    }
}
