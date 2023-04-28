internal class ThinkingPlayer
{
    
    private List<string> _aleatoryWords = new List<string>(){"DINOSAURIO", "SATELITE", "ESPIRAL", "MAIZAL"};
    public ThinkingPlayer()
    {
    }

    internal Word SelectWord()
    {
        Random rnd = new Random();
        var pos = rnd.Next(_aleatoryWords.Count);
        Word word = new Word(_aleatoryWords[pos]);
        return word;
    }
}