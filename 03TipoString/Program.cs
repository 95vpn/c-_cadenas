// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("hello\nWorld");
Console.WriteLine("Hello \tWorld");
Console.WriteLine("Hello \"World\"");
Console.WriteLine("hello\nWorld");
Console.WriteLine("C:\\source\\repos");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\"...\n");
Console.WriteLine("Invoice: 1021\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory");

Console.WriteLine(@"   c:\source\repos
            (this is where your code goes)");

Console.WriteLine(@"c:\invoices");

//Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World");
//Console.WriteLine("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");

string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + @"!";
Console.WriteLine(message);

Console.WriteLine(greeting + " " + firstName + "!");



Console.WriteLine(greeting + " " + firstName + "!");

string message1 = $"{greeting} {firstName}";
string message2 = $"Hello {firstName}";
Console.WriteLine(message1);
Console.WriteLine(message2);

int version = 11;
string updateText = "Update to Windows";
string message3 = $"{updateText} {version}!";
Console.WriteLine(message3);

string projectName = "first-Project";
Console.WriteLine($@"c:\Output\{projectName}\Data");

string projectName1 = "ACME";
//string russianMessage = "\u041f\u0441\u043c\u043e\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($"View English output: \n c:\\Exercise\\{projectName1}\\data.txt");

//Console.WriteLine($"{russianMessage}: \n c:\\Exercise\\{projectName}\\ry-RU\\data.txt");
