using System.IO;


public class LocalStorage : IStorage
{
    string FilePath { get; set; }
    public LocalStorage(string filePath)
    {
        filePath = this.FilePath;
    }
    public void SaveFile(string nameFile, string content)
    {
        StreamWriter writer = new StreamWriter(FilePath);
        writer.Write(content);
        if (File.Exists(FilePath))
            Console.WriteLine("File saved successfully");
        else
            Console.WriteLine("Error while saving the file");
    }

    public string LoadFile(string nameFile)
    {
        StreamReader reader = new StreamReader(FilePath);
        if (File.Exists(FilePath))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine("File contents");
            Console.WriteLine(content);
            return "";
        }
        return "The file cannot be located.";

    }

}