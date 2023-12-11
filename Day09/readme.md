# Day 9
1. Превоз на товари (Cargo Transport)
2. Междузвездни войни (StarWars)
3. Междузвездни войни. Империята отвръща на удара (StarWars. Impery Strikes Back)
4. В най-тъмните подземия (Dungeonest Dark)

## Console.cs
```cs
public static class Console
{
	public static void WriteLine(string s)
	{
		var colorBackup = System.Console.ForegroundColor;
		System.Console.ForegroundColor = System.ConsoleColor.Green;
		System.Console.WriteLine(s);
		System.Console.ForegroundColor = colorBackup;
	}
}
```
_Updated: 04.12.2023_
