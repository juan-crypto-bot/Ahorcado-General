internal class GuessingPlayer
{
    internal Letter GetLetter()
    {
        //Console.WriteLine("Ingrese una letra: ");
            char letter;
            do{
                letter = Console.ReadKey().KeyChar;
                Thread.Sleep(1000);
                Console.WriteLine(" ");
                return new Letter(char.ToUpper(letter));
            }
            while(Char.IsAsciiLetterOrDigit(letter));
            //return new Letter(char.ToUpper(letter));
    }
}