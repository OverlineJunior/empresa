class Estado {
    public readonly string Nome;
    public readonly string UF;
    public readonly int Codigo;
    public readonly Pais Pais;

    public Estado(string nome, string uf, int codigo, Pais pais) {
        Nome = nome;
        UF = uf;
        Codigo = codigo;
        Pais = pais;
    }
}
