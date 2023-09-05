class Funcionario : Pessoa {
    protected string Matricula;
    protected decimal SalBase;
    protected decimal GratProd;
    protected int NumDependentes;

    public Funcionario(
        string nome,
        int idade,
        Sexo sexo,
        string matricula,
        decimal salBase,
        decimal gratProd,
        int numDependentes
    ) : base(nome, idade, sexo) {
        Matricula = matricula;
        SalBase = salBase;
        GratProd = gratProd;
        NumDependentes = numDependentes;
    }

    public virtual decimal CalcularSalarioBruto() {
        return SalBase + GratProd;
    }

    public virtual decimal CalcularDesconto() {
        decimal salBruto = CalcularSalarioBruto();

        return salBruto switch {
            <= 1000 => 0,
            <= 1800 => salBruto * 0.1M - 100,
            _ => salBruto * 0.25M - 370,
        };
    }

    public decimal CalcularSalarioLiquido() {
        return CalcularSalarioBruto() - CalcularDesconto();
    }

    public override void Mostrar() {
        base.Mostrar();

        Console.WriteLine();

        Console.WriteLine("[Funcionario]");
        Console.WriteLine($"Matricula:                {Matricula}");
        Console.WriteLine($"SalBase:                  {SalBase}");
        Console.WriteLine($"GratProd:                 {GratProd}");
        Console.WriteLine($"NumDependentes:           {NumDependentes}");
        Console.WriteLine($"CalcularSalarioBruto():   {CalcularSalarioBruto()}");
        Console.WriteLine($"CalcularSalarioLiquido(): {CalcularSalarioLiquido()}");
    }
}
