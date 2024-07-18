class Banda
{
    public Banda(string nome)
    {
        this.Nome = nome;

    }
    private List<Album> albums = new List<Album>();
    public string Nome { get; }

    public void AdcionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Dicografia da banda {Nome}");
        foreach(var album in albums)
        {
            Console.WriteLine($"-{album.Nome} ({album.DuracaoTotal})");
        }
    }
}