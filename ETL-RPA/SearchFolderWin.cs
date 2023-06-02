using System.IO;

public class SearchFolderWin : SearchFolder
{
    public List<string> folders = new List<string>();
    public List<string> foldersExt = new List<string>();

    public override List<string> GetPath(string rootFolderPath)
    {
        folders = Directory.GetDirectories(rootFolderPath)
                           .ToList();

        foreach (var f in folders)
        {
          foldersExt = Directory.GetDirectories(f)
                           .ToList();
          
        }
    
        return foldersExt;
    }

    public override void SearchingFolder(string extensionFile,
                                            List<string> foldersPath)
    {
        foreach (var folderPath in folders)
        {
            Console.WriteLine(folderPath);
        }
    }
}