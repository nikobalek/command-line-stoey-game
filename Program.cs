Console.Title = "First Game";
string name;

aiSay("Hello, World!");
name = aiAsk("Whats your name?");
aiSay("hello " + name + "!");
Console.ReadKey();

void aiSay(string text, ConsoleColor color = ConsoleColor.Green)
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
}

string aiAsk(string text, ConsoleColor color = ConsoleColor.Green)
{
    string answear;
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
    answear = Console.ReadLine();
    return answear;
}