public class FolderCretorWin : FolderCretor
{

    public override string NewFolder(string urlFolder, string nameFolder)
    {
        if (!Directory.Exists(urlFolder+nameFolder))
        {
            Directory.CreateDirectory(urlFolder+nameFolder);
        }

        return urlFolder+nameFolder;
    }
}
