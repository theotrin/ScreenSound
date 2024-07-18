class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => (int)musicas.Sum(musi => musi.Duracao);

    public void AdicionarMusica (Musica musica)
    {
        musicas.Add (musica);

    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"Lista de musicas do album {Nome}: ");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"-{musica.Nome}");
        }
        Console.WriteLine($"Para ouvir esse album inteiro você precisa de {DuracaoTotal} minutos!");
    }
}