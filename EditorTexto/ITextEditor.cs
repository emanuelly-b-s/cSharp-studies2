interface ITextEditor
{
    string Write();
    void UndoAction();
    void RedoAction ();
    void SaveChanges();
    void Delete();

}