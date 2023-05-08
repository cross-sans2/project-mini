using System;
using System.IO;

class ScriptEngine
{
    public void ExecuteScript(string script)
    {
        // TODO: Implement script execution
    }
}

class Game
{
    static void Main()
    {
        ScriptEngine scriptEngine = new ScriptEngine();

        Console.WriteLine("Welcome to the game!");
        Console.WriteLine("Type 'help' for a list of commands.");

        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            else if (input == "help")
            {
                Console.WriteLine("Available commands:");
                Console.WriteLine("quit - Quit the game");
                Console.WriteLine("help - Show a list of commands");
            }
            else if (input.StartsWith("run "))
            {
                string scriptFilename = input.Substring(4);

                if (File.Exists(scriptFilename))
                {
                    string script = File.ReadAllText(scriptFilename);
                    scriptEngine.ExecuteScript(script);
                }
                else
                {
                    Console.WriteLine("Script file not found.");
                }
            }
            else
            {
                Console.WriteLine("I don't understand.");
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}
