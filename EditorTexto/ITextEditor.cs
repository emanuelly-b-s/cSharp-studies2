interface ITextEditor
{
    string Write(string txt);
    void UndoAction();
    void RedoAction ();
    void SaveChanges();
    void Delete();

}