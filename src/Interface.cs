class Interface {
    public void LerDadosUsuario(
        ref string nome,
        ref Cidade cidade,
        ref Cargo cargo,
        ref string matricula,
        ref int numDependentes,
        ref decimal salBase,
        ref decimal gratProd,
        ref decimal gratChefia
    ) {
        nome = PedirDado<string>("Nome: ");
        cidade = PedirCidade("Cidade ([Foz do Iguacu], [Curitiba]): ");
        cargo = PedirCargo("Cargo ([F]uncionario, [C]hefe, [A]poio): ");
        matricula = PedirDado<string>("Matricula: ");
        numDependentes = PedirDado<int>("Numero de dependentes: ");
        salBase = PedirDado<decimal>("Salario base: ");
        gratProd = PedirDado<decimal>("Gratificacao de producao: ");
        gratChefia = cargo == Cargo.Chefe
            ? PedirDado<decimal>("Valor de gratificacao de produtividade de chefia: ")
            : 0;
    }

    private T PedirDado<T>(string msg) {
        Console.Write(msg);

        string entrada = Console.ReadLine() ?? "";

        if (entrada == "") {
            Console.Write("A entrada nao pode ser vazia\nTente novamente: ");
            return PedirDado<T>("");
        }

        try {
            return (T)Convert.ChangeType(entrada, typeof(T));
        } catch (Exception) {
            return PedirDado<T>("Nao foi possivel converter a entrada\nTente novamente: ");
        }
    }

    private Cargo PedirCargo(string msg) {
        Console.Write(msg);

        Cargo? cargo = PedirDado<string>("").ToUpper() switch {
            "F" => Cargo.Funcionario,
            "C" => Cargo.Chefe,
            "A" => Cargo.Apoio,
            _ => null,
        };

        return cargo ?? PedirCargo("O cargo precisa ser representado por [F]uncionario, [C]hefe ou [A]poio\nTente novamente: ");
    }

    private Cidade PedirCidade(string msg) {
        Console.Write(msg);

        Pais brasil = new Pais("Brasil", "BR", "Real", 123);
        Estado parana = new Estado("Parana", "41", 123, brasil);
        
        Cidade? cidade = PedirDado<string>("").ToUpper() switch {
            "FOZ DO IGUACU" => new Cidade("Foz do Iguacu", "45", 123, parana),
            "CURITIBA" => new Cidade("Curitiba", "41", 123, parana),
            _ => null,
        };

        return cidade ?? PedirCidade("A cidade precisa ser representada por [Foz do Iguacu] ou [Curitiba]\nTente novamente: ");
    }
}
