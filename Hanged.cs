internal class Hanged
{

    public Hanged()
    {
    }

    internal void Play()
    {
        Word word = new ThinkingPlayer().SelectWord();
        Hang hang = new Hang();
        GuessingPlayer guessingPlayer = new GuessingPlayer();
        do
        {
            Console.Clear();
            hang.Display();
            word.Display();
            guessingPlayer.DisplayAttempts();
            char letter = guessingPlayer.GetLetter();
            if (word.ContainsLetter(letter))
            {
                word.Discovery(letter);
            }
            else
            {
                hang.DecreaseLife();
            }
        } while (!hang.isLoser() && !word.isWinner());
        Console.Clear();
        if (word.isWinner())
        {
            Console.WriteLine("Ganaste!");
        }
        else
        {
            hang.Display();
            word.Display();
            Console.WriteLine("Perdiste :(");
        }
    }
}