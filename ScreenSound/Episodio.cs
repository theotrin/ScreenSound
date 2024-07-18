class Episodio
{
    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }
    private List<string> convidados = new();
    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao})min - Convidados: {string.Join(", ", convidados)}";

    public void AdcionarConvidados (string convidado)
    {
        convidados.Add(convidado);
    }

}