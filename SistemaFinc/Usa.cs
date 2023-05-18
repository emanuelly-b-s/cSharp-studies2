public class UsaDismissalProcess : DismissalProcess
{
    public override string Title => "Employee Termination";

    public override void Apply(DismissalArgs args)
    {
        args.Company.Money -= 4 * args.Employe.Wage;
    }
}

public class UsaWagePaymentProcess : WagePaymentProcess
{
    public override string Title => "Salary Payment";

    public override void Apply(WagePaymentArgs args)
    {
        args.Company.Money -= 0.7m * args.Employe.Wage + 100;
    }
}

public class UsaContractProcess : ContractProcess
{
    public override string Title => "Hired Employe";

    public override void Apply(ContractArgs args)
    {
        args.Company.Money -= 0.2m * args.Employe.Wage;
    }

}


public class UsaProcessFactory : IProcessFactory
{
    public DismissalProcess CreateDismissalProcess()
    => new UsaDismissalProcess();

    public WagePaymentProcess CreateWagePaymentProcess()
    => new UsaWagePaymentProcess();

    public ContractProcess CreateContractProcess()
    => new UsaContractProcess();
}