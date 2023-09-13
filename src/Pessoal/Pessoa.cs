class Pessoa {
    protected string Nome;
    protected int Idade;
    protected Sexo Sexo;
    protected Cidade Cidade;
    
    public Pessoa(string nome, int idade, Sexo sexo, Cidade cidade) {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
        Cidade = cidade;
    }

    public virtual void Mostrar() {
        Console.WriteLine("[Pessoa]");
        Console.WriteLine($"Nome:   {Nome}");
        Console.WriteLine($"Idade:  {Idade}");
        Console.WriteLine($"Sexo:   {Sexo}");
        Console.WriteLine($"Cidade: {Cidade.Nome}");
    }
}
