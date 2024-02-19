namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            var rNum = new Random();
            var favNumber = rNum.Next(1, 1000);
            Console.WriteLine("Guess my favorite number between 1 and 1000");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
            {
                Console.WriteLine($"Your guess was too low.\nMy number was {favNumber}.");
            } else if (userInput > favNumber)
            {
                Console.WriteLine($"Your guess was too high.\nMy number was {favNumber}.");
            } else
            {
                Console.WriteLine("You guessed it!!!");
            }
        }
    }
}
