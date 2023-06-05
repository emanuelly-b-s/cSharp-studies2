using System.IO;
using System.Management.Automation;
using System.Text;

public class SearchFolderWin : SearchFolder
{
    private List<string> repName = new List<string>();

    public List<string> ListGetRepName { get => repName; }


    public override List<string> GetPath(string dir, string ext)
    {

        // foreach (var dir in ls)
        // {
        //     // Console.WriteLine(dir);
        //     var ls2 = Directory.EnumerateDirectories(dir);
        //     foreach (var item in ls2)
        //     {
        //         Console.WriteLine(item);

        //         if(item.EndsWith(".git"))
        //             teste.Add(dir);
        //             Console.WriteLine(Path.GetFileName(dir));
        //     }

        // }

        var ls = Directory.EnumerateDirectories(dir);

        foreach (var d in ls)
        {

            // Console.WriteLine(d);
            var ls2 = Directory.EnumerateDirectories(d);
            foreach (var item in ls2)
            {
                if (item.EndsWith(".git"))
                {
                    string dirNames = item.Replace("\\.git", string.Empty);
                    repName.Add(Path.GetFileName(dirNames));

                }
            }
        }

        // foreach (var item in repName)
        // {
        //     Console.WriteLine(item);
        // }

        // var ls = Directory.EnumerateDirectories(dir, "*", SearchOption.AllDirectories)
        //                   .Where(d => d.EndsWith(".git"));

        // foreach (var d in ls)
        // {

        //     string dirNames = dir.Replace("\\.git", string.Empty);
        //     string repoName = Path.GetFileName(dirNames);

        //     foreach (var item in repoName)
        //     {
        //         Console.WriteLine(item);
        //     }
        return repName;
    }

    // }
}