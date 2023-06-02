using System.IO;
using System.Linq;

public abstract class SearchFolder
{
    // public List<string> folders = new List<string>();]
    public abstract List<string> GetPath(string rootFolderPath);
    
    public abstract void SearchingFolder(string extensionFile, List<string> foldersPath);
}