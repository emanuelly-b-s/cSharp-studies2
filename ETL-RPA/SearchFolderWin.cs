using System.IO;

public class SearchFolderWin : SearchFolder
{
    public List<string> folders = new List<string>();
    public List<string> foldersExt = new List<string>();

    public override void GetPath(string rootFolderPath)
    {

        var ls = Directory.EnumerateDirectories(@"C:\Users\disrct\Desktop\_C#-Avançado-GIT\.git").ToList();

        foreach (var dir in ls)
            Console.WriteLine(dir);

        
    }

}