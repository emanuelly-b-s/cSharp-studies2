using System.Management.Automation;

public abstract class ComandosGit
{
    public abstract void Repositories(SearchFolderWin repositories);

}

public class GitPull : ComandosGit
{
    public override void Repositories(SearchFolderWin repositories)
    {
        var repNames = repositories.ListGetRepName;
        using var ps = PowerShell.Create();

        foreach (var repo in repNames)
        {
            Console.WriteLine(repo);
            try
            {
                ps.AddCommand("git")
                  .AddArgument("pull")
                  .AddArgument("origin")
                  .AddArgument("main")
                  .AddArgument(repo)
                  .Invoke();

                Console.WriteLine($"Pull sucessfully");
            }
            catch
            {
                Console.WriteLine($"Failed to pull");
            }
            finally
            {
                ps.Commands.Clear();
            }
        }
    }
}