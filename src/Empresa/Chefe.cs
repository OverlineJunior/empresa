class Chefe : Funcionario {
    protected decimal GratChefia;

    public Chefe(
        string nome,
        int idade,
        Sexo sexo,
        string matricula,
        decimal salBase,
        decimal gratProd,
        int numDependentes,
        decimal gratChefia
    ): base(nome, idade, sexo, matricula, salBase, gratProd, numDependentes) {
        GratChefia = gratChefia;
    }

    public override decimal CalcularSalarioBruto() {
        return base.CalcularSalarioBruto() + GratChefia;
    }

    public override void Mostrar() {
        base.Mostrar();

        Console.WriteLine();

        Console.WriteLine("[Chefe]");
        Console.WriteLine($"GratChefia: {GratChefia}");
    }
}
