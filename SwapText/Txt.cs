namespace SwapText;

public class Txt
{
    public void Swaptext(ref string x, ref string y)
    {
        string temp = x;
        x = y;
        y = temp;
    }
}
