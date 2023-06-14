Console.WriteLine("Hello, World!");
var keepRunning = true;

await Task.Delay(1000);

do
{
    Console.Clear();
    Console.Write("Type the command: ");
    var command = Console.ReadLine();

    switch (command?.ToLower())
    {
        case "variables":
            {
                Console.WriteLine("Variables\n");

                Console.Write("This is the variable (A) with is a string, type it's value: ");
                var A = Console.ReadLine();

                Console.WriteLine($"The value typed for (A) is: {A}");
            }
            break;
    }

    Console.Write("\n\nType enter to continue..."); 
    Console.ReadLine();
    keepRunning = command != "exit";
} while (keepRunning);