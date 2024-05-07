Console.Title = "First Game";

aiSay("Hello, World!");
var name = aiAsk("Whats your name?");
aiSay("hello " + name + "!");
Console.ReadKey();

void aiSay(string text)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(text);
    Console.ForegroundColor = ConsoleColor.White;
}

string aiAsk(string text)
{
    string answear;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(text);
    Console.ForegroundColor = ConsoleColor.White;
    answear = Console.ReadLine();
    return answear;   
}