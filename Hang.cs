internal class Hang
{

    public int _lives;
    private string[] _drawing;

    public Hang(){
        this._lives = 6;
        this._drawing = new string[]{
                    " ____      \n" +
                    "|    |     \n" +
                    "|   (¨)    \n" +
                    "|   /|\\   \n" +
                    "|   / \\   \n" +
                    "|          \n" +
                    "☰☰☰☰☰☰",
                    " ____      \n" +
                    "|    |     \n" +
                    "|   (¨)    \n" +
                    "|   /|\\   \n" +
                    "|   /      \n" +
                    "|          \n" +
                    "☰☰☰☰☰☰",
                    " ____      \n" +
                    "|    |     \n" +
                    "|   (¨)    \n" +
                    "|   /|\\   \n" +
                    "|          \n" +
                    "|          \n" +
                    "☰☰☰☰☰☰",
                    " ____      \n" +
                    "|    |     \n" +
                    "|   (¨)    \n" +
                    "|   /|     \n" +
                    "|          \n" +
                    "|          \n" +
                    "☰☰☰☰☰☰",
                    " ____      \n" +
                    "|    |     \n" +
                    "|   (¨)    \n" +
                    "|    |     \n" +
                    "|          \n" +
                    "|          \n" +
                    "☰☰☰☰☰☰",
                    " ____      \n" +
                    "|    |     \n" +
                    "|   (¨)    \n" +
                    "|          \n" +
                    "|          \n" +
                    "|          \n" +
                    "☰☰☰☰☰☰",
                    " ____      \n" +
                    "|    |     \n" +
                    "|          \n" +
                    "|          \n" +
                    "|          \n" +
                    "|          \n" +
                    "☰☰☰☰☰☰"
        };
    }

    internal bool isLoser()
    {
        if(this._lives == 0) return true;
        else return false;
    }

    internal void DecreaseLife()
    {
        this._lives--;
    }

    internal void Display()
    {
        Console.WriteLine(this._drawing[this._lives]);
    }
}