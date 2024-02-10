using SwapText;

class Program
{
    static void Main(string[] args)
    {
        Txt txt = new Txt();

        Console.Write("Type your first word: ");
        string wordOne = Console.ReadLine();
        
        Console.Write("Type your second word: ");
        string wordTwo = Console.ReadLine();
        
        Console.WriteLine($"Before the swap: {wordOne} {wordTwo}");
        
        txt.Swaptext(ref wordOne, ref wordTwo);
        
        Console.WriteLine($"After the swap: {wordOne} {wordTwo}");
    }
}