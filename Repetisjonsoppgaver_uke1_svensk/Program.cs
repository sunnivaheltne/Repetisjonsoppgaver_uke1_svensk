namespace Repetisjonsoppgaver_uke1_svensk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            var randomNumber = random.Next(1, 10);

            var antall = 0;

            Console.WriteLine("Guess a random number between 1 and 10:");

            while (antall < 3)
            {
                antall++;

                var input = Convert.ToInt32(Console.ReadLine());
                if (input == randomNumber)
                {
                    Console.WriteLine("You won!");
                    break;
                }

                else if (antall >= 3)
                {
                    Console.WriteLine("You're out of guesses.");
                }
                else
                {
                    Console.WriteLine("That's wrong, guess again:");
                }
            }

            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("What's your name?");
            //var name = Console.ReadLine();

            //if (name == "Sunniva")
            //{
            //    Console.WriteLine("Hello, you!");
            //}
            //else
            //{
            //    var teller = 0;
            //    while (teller < 10)
            //    {
            //        teller++;
            //        Console.WriteLine($"Hello, {name}!");
            //    }    
            //}
        }
    }
}