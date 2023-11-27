namespace Shop;

public static class Console
{
    public static void WriteLine(string text)
    {
        var color = System.Console.ForegroundColor;
        System.Console.ForegroundColor = System.ConsoleColor.Green;
        System.Console.WriteLine(text);
        System.Console.ForegroundColor = color;
    }
}