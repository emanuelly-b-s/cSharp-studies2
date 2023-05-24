public abstract class TextEditor : ITextEditor
{
    private string Text;
    private string SavedText;
    public virtual void Delete(){}
    public virtual void RedoAction(){}
    public virtual void SaveChanges(){}
    public virtual void UndoAction(){}

    public virtual string Write(string txt) 
    {
        return txt;
    }
    
}