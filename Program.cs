using ConsoleApp1;
using System;
using System.IO;  
using System.Text;
using System.Text.Json;


namespace ConsoleApp1
{
class Program
{
    static void Main()
    {
        LoadConfig("");
        }

        public static void LoadConfig(string ConfigFilePath)
    {
        ConfigFilePath = "config.json";
        try
        {
            ConfigJson configJsonObj = new ConfigJson();

                if (File.Exists(ConfigFilePath))
                {
                string json = File.ReadAllText(ConfigFilePath);
                var config = JsonSerializer.Deserialize<ConfigJson>(json);
                    if (config!=null && !String.IsNullOrEmpty(config.MongoURL))
                    {


                        Config.MongoURL = config.MongoURL;
                        Config.DataBaseName = config.DataBaseName;
                        Config.PortName = config.PortName;
                        Config.senderID = config.senderID;
                        Config.BaudRate = config.BaudRate;
                        Console.WriteLine(json);
                        return;
                    }
                

                }
                configJsonObj = new ConfigJson();
                string newJson = JsonSerializer.Serialize(configJsonObj);
                File.WriteAllText(ConfigFilePath, newJson);
                Console.WriteLine("A json file generated.");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading configuration: {ex.Message}");
        }
    }

    static string ConvertToUTF16(string input)
    {
        StringBuilder utf16Builder = new StringBuilder();

        foreach (char c in input)
        {

            utf16Builder.Append(GetUtf16Code(c));
        }

        return utf16Builder.ToString();
    }

    static string GetUtf16Code(char c)
    {
        return ((int)c).ToString("X4");
    }
}

    }
