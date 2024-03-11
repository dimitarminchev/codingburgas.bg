# Day 09. Допълнителни задачи.
- 13. Допълнителни задачи

## Решени задачи
1. Превоз на товари (Cargo Transport)
2. Междузвездни войни (StarWars)

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
