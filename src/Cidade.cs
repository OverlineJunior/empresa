class Cidade {
    public readonly string Nome;
    public readonly string DDD;
    public readonly int Codigo;
    public readonly Estado Estado;

    public Cidade(string nome, string ddd, int codigo, Estado estado) {
        Nome = nome;
        DDD = ddd;
        Codigo = codigo;
        Estado = estado;
    }    
}
