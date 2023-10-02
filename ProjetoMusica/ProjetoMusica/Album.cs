class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Musicas do album {Nome} ");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir este álbum inteiro você precia de {DuracaoTotal}\n");
    }    


}
