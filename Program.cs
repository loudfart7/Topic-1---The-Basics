using System.Data;

namespace Topic_1___The_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Joel
            string firstName = "Joel";
            string favMovie = "The Matrix";
            string TrueFalse = "False";
            string quote = "The stuff that dreams are made of.";

            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();

            Console.WriteLine($"Hello, {firstName}! What do you think about {favMovie}?");
            
            favMovie = favMovie.ToUpper();
            Console.WriteLine();
            Console.WriteLine(favMovie);

            Console.WriteLine();

            if (favMovie.Contains("THE"));
                TrueFalse = "True";
                Console.WriteLine( $"Does '{favMovie}' contain the word 'THE'?");
                Console.WriteLine(TrueFalse);

            Console.WriteLine();

            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine(favMovie);

            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();


            Console.WriteLine(quote);
            quote = quote.ToUpper();
            Console.WriteLine(quote);

            quote = quote.Replace("A", " ");
            quote = quote.Replace("E", " ");
            quote = quote.Replace("I", " ");
            quote = quote.Replace("O", " ");
            quote = quote.Replace("U", " ");
            quote = quote.Replace("Y", " ");

            Console.WriteLine(quote);

            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();

            Console.WriteLine("    |\\__ /,| (`\\          /\\_/\\            __ ");
            Console.WriteLine("  _.| o o | _) )         = o_o =_______    \\ \\");
            Console.WriteLine("  -(((---(((--------      __^      __(  \\.__) )");
            Console.WriteLine("                      (@)<_____>__(_____)____/");

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();

        }
    }
}
