using System.IO;
using System.Management.Automation;

using var ps = PowerShell.Create();

FolderCretor newFolder = new FolderCretorWin();
SearchFolder folders = new SearchFolderWin();
List<string> teste = new List<string>();
List<string> test = new List<string>();

string rootPath = @"C:\Users\disrct\Desktop\_C#-Avançado-GIT\ETL-RPA\Rep\";
string extensionGit = ".git";

ps.AddCommand(newFolder.NewFolder(rootPath, "ateste"));

folders.GetPath(rootPath);




