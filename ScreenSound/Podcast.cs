class Podcast
{
    private List<Episodio> episodios = new();

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; set; }
    public string Nome { get; set; }
    public int TotalEpisodios => episodios.Count;


    public void AdcionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine(Nome);
        Console.WriteLine($"\nApresentador: {Host}\n");
        Console.WriteLine("Lista de episodios:");
        foreach (var episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo);
            Console.WriteLine($"Episodios: {TotalEpisodios}");
        }
    }
}