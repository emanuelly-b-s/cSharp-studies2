public interface IStorage
{
    void SaveFile (string nameFile, string content, string filePath);
    string LoadFile (string nameFile, string filePath);
}