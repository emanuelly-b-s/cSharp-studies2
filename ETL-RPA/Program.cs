using System.IO;
using System.Management.Automation;

using var ps = PowerShell.Create();

FolderCretor newFolder = new FolderCretorWin();

ps.AddCommand(newFolder.NewFolder(@"C:\Users\disrct\Desktop\_C#-Avançado-GIT\ETL-RPA\Rep\", "ateste"));

 