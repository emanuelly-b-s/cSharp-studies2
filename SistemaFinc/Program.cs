
var builder = Company.GetBuilder();

builder
    .SetName("Mercado Libre")
    .InArgentina()
    .SetInitialCapital(20_000_000);

builder
    .AddEmploye("Marquitos Guapo", 50_000)
    .AddEmploye("Paulito Pino", 20_000);

Company.New(builder);

// Me rendí, me voy a Brasil
builder = Company.GetBuilder();

builder
    .SetName("Mercado Livre")
    .InBrazil()
    .SetInitialCapital(1_000_000);

builder
    .AddEmploye("Marcos Bonito", 2_500)
    .AddEmploye("Paulo Pinheiro", 1_000);

Company.New(builder);

// To go to Brazil, I'm love Amazonia
builder = Company.GetBuilder();

builder
    .SetName("Free Market")
    .InUsa()
    .SetInitialCapital(1_000_000_0);

builder
    .AddEmploye("Angela", 7_000)
    .AddEmploye("Pam", 6_000);

Company.New(builder);

Employe employe = new Employe();
employe.Name = "Xispita";
employe.Wage = 2_000;
Company.Current.Contract(employe);

Company.Current.ListEmployes();


// Company.Current.Dismiss("Marcos Bonito");

// Company.Current.PayWages();