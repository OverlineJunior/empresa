class Apoio : Funcionario {
    public Apoio(
        string nome,
        int idade,
        Sexo sexo,
        Cidade cidade,
        string matricula,
        decimal salBase,
        decimal gratProd,
        int numDependentes
    ): base(nome, idade, sexo, cidade, matricula, salBase, gratProd, numDependentes) {}

    public decimal CalcularAuxilioEducacao() {
        return Math.Clamp(NumDependentes * 60, 0, 5 * 60);
    }

    public override decimal CalcularSalarioBruto() {
        return base.CalcularSalarioBruto() + CalcularAuxilioEducacao();
    }

    public override decimal CalcularDesconto() {
        return 0;
    }

    public override void Mostrar() {
        base.Mostrar();

        Console.WriteLine();

        Console.WriteLine("[Apoio]");
        Console.WriteLine("-");
    }
}
