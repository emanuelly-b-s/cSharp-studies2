public class BrazilDismissalProcess : DismissalProcess
{
    public override string Title => "Demissão de Funcionário";

    public override void Apply(DismissalArgs args)
    {
        args.Company.Money -= 2 * args.Employe.Wage;
    }
}

public class BrazilWagePaymentProcess : WagePaymentProcess
{
    public override string Title => "Pagamento de Salário";

    public override void Apply(WagePaymentArgs args)
    {
        args.Company.Money -= 1.45m * args.Employe.Wage + 500;
    }
}

public class BrazilContractProcess : ContractProcess 
{
     public override string Title => "Contratado :)";

    public override void Apply(ContractArgs args)
    {
        args.Company.Money -= 0.7m * args.Employe.Wage;
    }
}

public class BrazilProcessFactory : IProcessFactory
{
    public DismissalProcess CreateDismissalProcess()
    => new BrazilDismissalProcess();

    public WagePaymentProcess CreateWagePaymentProcess()
    => new BrazilWagePaymentProcess();

    public ContractProcess CreateContractProcess()
    => new BrazilContractProcess();
}