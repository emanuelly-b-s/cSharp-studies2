﻿using System.IO;
using System.Management.Automation;

using var ps = PowerShell.Create();

FolderCretor newFolder = new FolderCretorWin();
SearchFolder folders = new SearchFolderWin();
ComandosGit pull = new GitPull();
ComandosGit add = new GitAdd();
ComandosGit push = new GitPush();


List<string> teste = new List<string>();
List<string> test = new List<string>();

string rootPath = @"C:\Users\disrct\Desktop\_C#-Avançado-GIT";
string extensionGit = ".git";

// // ps.AddCommand(newFolder.NewFolder(rootPath, "ateste"));

folders.GetPath(rootPath, extensionGit);

add.Repositories((SearchFolderWin)folders);
push.Repositories((SearchFolderWin)folders);

// var ls = Directory.EnumerateDirectories(rootPath);

// 


// foreach (var dir in teste)
// {
//     var ls2 = Directory.EnumerateDirectories(dir);
//     Console.WriteLine(dir);
//     teste.Add(dir);
// }