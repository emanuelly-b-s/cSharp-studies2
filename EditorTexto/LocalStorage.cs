using System.IO;
using StreamWriter;
using StreamReader;

public class LocalStorage : IStorage
{

    void SaveFile (string nameFile, string content, string filePath)
    {
        StreamWriter writer = new StreamWriter(filePath);
        writer.Write(content);
        if(File.Exists(filePath))
            Console.WriteLine("File saved successfully");
        else
            Console.WriteLine("Error while saving the file");
    }

    string LoadFile (string nameFile, string filePath)
    {
        StreamReader reader = new StreamReader(filePath);
        if(File.Exists(filePath))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine("File contents");
            Console.WriteLine(content);
        }
        else 
            Console.WriteLine("The file cannot be located.");
    }
    // public LocalStorage()
    // {
    // }
}