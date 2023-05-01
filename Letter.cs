internal class Letter
{
    public char _v;
    private bool _hidden;

    public Letter(char v)
    {
        this._v = v;
        this._hidden = true;
    }

    internal void Discovery()
    {
        this._hidden = false;
    }

    internal void Display()
    {
        if (this._hidden == true) Console.Write("_");
        else Console.Write(this._v);
    }

    internal bool isEqual(char letter)
    {

        return (this._v == letter);
    }

    internal bool isHidden()
    {
        return this._hidden == true;
    }
}