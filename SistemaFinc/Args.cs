public class Args
{
    private static ProcessArgs empty = new ProcessArgs();
    plubic static ProcessArgs Empty => empty;

}

public class DismissalArgs : ProcessArgs
{
    public Company Company { get; set; }
    public Employe Employe { get; set; }
}

public class WagePaymentArgs : ProcessArgs
{
    public Company Company { get; set; }
    public Employe Employe { get; set; }
}
