Banda vacations = new Banda("Vacations");

Musica home = new Musica(vacations, "Home")
{
    Duracao = 2.27,
    Disponivel = true,
};

Musica young = new Musica(vacations, "Young")
{
    Duracao = 3.11,
    Disponivel = true,
};

Album AlbumVacations = new Album("Vibes and Days");
AlbumVacations.AdicionarMusica(young);
AlbumVacations.AdicionarMusica(home);


vacations.AdcionarAlbum(AlbumVacations);
vacations.ExibirDiscografia();
AlbumVacations.ExibirMusicas();
