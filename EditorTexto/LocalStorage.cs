using System.IO;
using StreamWriter;
using StreamReader;

public class LocalStorage : IStorage
{
    string FilePath { get; set; }
    public LocalStorage (string filePath) => this.FilePath;
    void SaveFile (string nameFile, string content)
    {
        StreamWriter writer = new StreamWriter(filePath);
        writer.Write(content);
        if(File.Exists(filePath))
            Console.WriteLine("File saved successfully");
        else
            Console.WriteLine("Error while saving the file");
    }

    string LoadFile (string nameFile)
    {
        StreamReader reader = new StreamReader(filePath);
        if(File.Exists(filePath))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine("File contents");
            Console.WriteLine(content);
            return "";
        }
            return "The file cannot be located.";
        
    }
}