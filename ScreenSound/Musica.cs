class Musica 
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public double Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }
    public string DescricaoResumida => 
           $"A musica {Nome} pertence a banda: {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"-Nome: {this.Nome}\n-Artista: {this.Artista} \n-Duração: {this.Duracao}");
    }
}