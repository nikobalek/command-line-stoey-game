Console.Title = "First Game";
string name;

aiSay("Hello, Player! Welcome to this mini game!");
name = aiAsk("Whats your name?");

if (name == "Arian")
    aiSay("Thats a great name you have wise parents player!");
else
    aiSay(name + "?" + " who in the right mind would name their child that?!");

aiSay("Anyways " + name+"\nlet's get to the point! you came here for a game and im gonna give it to you!");
aiAsk("Are you ready?");
aiSay("Actully I dont give a fuck about what you said lets get to the point!");


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