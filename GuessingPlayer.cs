internal class GuessingPlayer
{
    private char[] _attempts;
    public GuessingPlayer()
    {
        this._attempts = new char[6];
    }
    public bool wasAttempted(char v)
    {
        int i = 0;
        while (i < this._attempts.Length - 1 && !(this._attempts[i] == v)) i++;
        if (this._attempts[i] == v)
        {
            System.Console.WriteLine("Caracter ya ingresado");
            return true;
        }
        return false;
    }

    public void addAttempt(char v)
    {
        int i = 0;
        while (i < this._attempts.Length - 1 && !(this._attempts[i] == '\0')) i++;
        this._attempts[i] = v;
    }

    internal void DisplayAttempts()
    {
        Console.WriteLine("Intentos: " + string.Join(" ", this._attempts));
    }

    internal char GetLetter()
    {
        Console.WriteLine("Ingrese una letra: ");
        char letter;
        do
        {
            letter = Console.ReadKey().KeyChar;
            Thread.Sleep(1000);
            Console.WriteLine("");
        }
        while (wasAttempted(letter));
        addAttempt(letter);
        return char.ToUpper(letter);
    }

}