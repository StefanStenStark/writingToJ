using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Tell me what you love with the command: dotnet run -ilove whatYouLove");
            Console.WriteLine("To see what you love you can write the command: dotnet run -what_do_i_love");
            return;
        }

        string flag = args[0];

        switch (flag)
        {
            case "-ilove":
                string dataString = args[1];
                SaveStringToJson(dataString);
                Console.WriteLine("String saved successfully.");
                break;

            case "-what_do_i_love":
                string retrievedString = RetrieveStringFromJson();
                if (!string.IsNullOrEmpty(retrievedString))
                {
                    Console.WriteLine($"You love: {retrievedString}");
                }
                else
                {
                    Console.WriteLine("You love nothing.");
                }
                break;

            default:
                Console.WriteLine("Unknown flag.");
                break;
        }
    }

    static void SaveStringToJson(string dataString)
    {
        File.WriteAllText("data.json", dataString);
    }

    static string RetrieveStringFromJson()
    {
        if (!File.Exists("data.json"))
        {
            return null;
        }

        return File.ReadAllText("data.json");
    }
}