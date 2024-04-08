# Day 09. Допълнителни задачи.
- Допълнителни задачи

## Решени задачи
- Превоз на товари (Cargo Transport)
- Междузвездни войни (StarWars)

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
