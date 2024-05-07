Console.Title = "First Game";

aiSay("Hello, World!");
var name = aiAsk("Whats your name?");
aiSay("hello " + name + "!");
Console.ReadKey();

void aiSay(string text, ConsoleColor color = ConsoleColor.Green)
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    color = ConsoleColor.White;
    Console.ForegroundColor = color;
}

string aiAsk(string text, ConsoleColor color = ConsoleColor.Green)
{
    string answear;
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    color = ConsoleColor.White;
    Console.ForegroundColor = color;
    answear = Console.ReadLine();
    return answear;   
}