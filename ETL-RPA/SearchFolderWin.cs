using System.IO;
using System.Management.Automation;
using System.Text;

public class SearchFolderWin : SearchFolder
{
    private List<string> repName = new List<string>();

    public List<string> ListGetRepName { get => repName; }


    public override List<string> GetPath(string dir, string ext)
    {

        var ls = Directory.EnumerateDirectories(dir, "*", SearchOption.AllDirectories)
                          .Where(d => d.EndsWith(".git"));

        foreach (var d in ls)
        {
            
            Console.WriteLine(d);

            string dirNames = dir.Replace("\\.git", string.Empty);
            string repoName = dirNames.Replace(dir, string.Empty);

                if (repoName.StartsWith('\\'))
                    repoName = repoName[1..];

                repName.Add(repoName);
            
            Console.WriteLine(repoName);
                

        }
        return ListGetRepName;
    }
}