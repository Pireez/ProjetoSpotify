Banda queen = new Banda("Queen");
Album albumQueen = new Album("A night at the opera");
Genero genero = new Genero("Rock");
Podcast host = new Podcast("Gustavo","Podpah");





Musica musica1 = new Musica(queen,"Love of my life",genero)
{
    Duracao = 213,
    Disponivel = true,
};


Musica musica2 = new Musica(queen, "Bohemian Rhapsody",genero)
{
    Duracao = 354,
    Disponivel = false,
};


Episodio episodio1 = new Episodio(host,host)
{
    Ordem = 1,
    Duracao = 3600,
    Titulo = "Viagem para Orlando",
};
Episodio episodio2 = new Episodio(host, host)
{
    Ordem = 2,
    Duracao = 3600,
    Titulo = "Viagem para londres",
};

Episodio episodio3 = new Episodio(host, host)
{
    Ordem = 3,
    Duracao = 3600,
    Titulo = "Viagem para Paris",
};





albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumQueen);
host.AdicionarEpisodio(episodio1);
host.AdicionarEpisodio(episodio2);
host.AdicionarEpisodio(episodio3);


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
queen.ExibirDiscografia();
albumQueen.ExibirMusicasDoAlbum();
host.ExibirDetalhes();


 

