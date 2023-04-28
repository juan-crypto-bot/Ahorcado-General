internal class Letter
{
    public char _v;
    private bool _hidden;

    public Letter(char v)
    {
        this._v = v;
        this._hidden=true;
    }

    internal void Discovery()
    {
        this._hidden = false;
    }

    internal void Display()
    {
         if(this._hidden == true) Console.Write("_");
        else Console.Write(this._v);
    }

    internal bool isEqual(Letter letter)
    {
        if(this._v == letter._v) return true;
        else return false;
    }

    internal bool isHidden()
    {
        if(this._hidden == true) return true;
        else return false;
    }
}