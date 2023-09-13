class Pessoa {
    protected string Nome;
    protected int Idade;
    protected Sexo Sexo;
    
    public Pessoa(string nome, int idade, Sexo sexo) {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }

    public virtual void Mostrar() {
        Console.WriteLine("[Pessoa]");
        Console.WriteLine($"Nome:  {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Sexo:  {Sexo}");
    }
}
