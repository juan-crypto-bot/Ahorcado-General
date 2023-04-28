internal class Hanged
{

    public Hanged()
    {
    }

    internal void Play()
    {
        Word word = new ThinkingPlayer().SelectWord();
        for(int i=0; i<word._word.Length; i++){
            Console.WriteLine(word._word[i]._v);
        }
        Hang hang = new Hang();
        GuessingPlayer guessingPlayer = new GuessingPlayer();
        do
        {
            hang.Display();
            word.Display();
            Letter letter = guessingPlayer.GetLetter();
            if (word.ContainsLetter(letter))
            {
                word.Discovery(letter);
            }
            else
            {
                hang.DecreaseLife();
            }
        } while (!hang.isLoser() || !word.isWinner());
        if (word.isWinner())
        {
            Console.WriteLine("Ganaste!");
        }
        else
        {
            Console.WriteLine("Perdiste :(");
        }
    }
}