public class FolderCretorWin : FolderCretor
{

    public override string NewFolder(string pathFolder, string nameFolder)
    {
        if (!Directory.Exists(pathFolder+nameFolder))
        {
            Directory.CreateDirectory(pathFolder+nameFolder);
        }

        return pathFolder+nameFolder;
    }
}
