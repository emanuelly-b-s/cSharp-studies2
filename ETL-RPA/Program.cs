﻿using System.IO;
using System.Management.Automation;

using var ps = PowerShell.Create();

FolderCretor newFolder = new FolderCretorWin();
SearchFolder folders = new SearchFolderWin();
ComandosGit pull = new GitPull();

List<string> teste = new List<string>();
List<string> test = new List<string>();

string rootPath = @"C:\Users\emanu\OneDrive\Área de Trabalho\cSharp-studies2\ETL-RPA";
string extensionGit = ".git";

// ps.AddCommand(newFolder.NewFolder(rootPath, "ateste"));

folders.GetPath(rootPath, extensionGit);

pull.Repositories((SearchFolderWin)folders);

