public interface IStorage
{
    void SaveFile (string nameFile, string content);
    string LoadFile (string nameFile);
}