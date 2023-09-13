class Empresa {
    protected string RazaoSocial;
    protected int NumFuncionarios;
    protected decimal Total;

    public Empresa(string razaoSocial, int numFuncionarios) {
        RazaoSocial = razaoSocial;
        NumFuncionarios = Math.Clamp(numFuncionarios, 0, numFuncionarios);
        Total = 0;
    }

    public void ProcessarFolha(Interface interface_) {
        for (int i = 0; i < NumFuncionarios; i++) {
            string nome = "";
            Cidade cidade = new("", "", 0, new Estado("", "", 0, new Pais("", "", "", 0)));
            Cargo cargo = Cargo.Funcionario;
            string matricula = "";
            int numDependentes = 0;
            decimal salBase = 0;
            decimal gratProd = 0;
            decimal gratChefia = 0;

            interface_.LerDadosUsuario(ref nome, ref cidade, ref cargo, ref matricula, ref numDependentes, ref gratProd, ref gratChefia, ref salBase);

            Funcionario funcionario = cargo switch {
                Cargo.Funcionario => new Funcionario(
                    nome,
                    18,
                    Sexo.Masculino,
                    cidade,
                    matricula,
                    salBase,
                    gratProd,
                    numDependentes
                ),
                Cargo.Chefe => new Chefe(
                    nome,
                    18,
                    Sexo.Masculino,
                    cidade,
                    matricula,
                    salBase,
                    gratProd,
                    numDependentes,
                    gratChefia
                ),
                Cargo.Apoio => new Apoio(
                    nome,
                    18,
                    Sexo.Masculino,
                    cidade,
                    matricula,
                    salBase,
                    gratProd,
                    numDependentes
                ),
                _ => throw new ArgumentOutOfRangeException(nameof(cargo)),
            };

            Total += funcionario.CalcularSalarioBruto();
            funcionario.Mostrar();
        }
    }
}
