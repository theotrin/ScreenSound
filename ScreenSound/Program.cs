Episodio episodio1 = new Episodio(60, 1, "Programação orientada a objetos");
episodio1.AdcionarConvidados("Gustavo Guanabera");

Console.WriteLine(episodio1.Resumo);

Podcast podcast = new Podcast("Theo", "True Programing");

podcast.AdcionarEpisodio(episodio1);

podcast.ExibirDetalhes();