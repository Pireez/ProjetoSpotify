class Podcast
{
    private List<Episodio> episodios =new List<Episodio>();
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host {  get; }
    public string Nome { get;  }
    public int TotalEpisodios => episodios.Count();

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} Apresentador: {Host}");
        foreach (var episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Total de episodios: {TotalEpisodios}");
    }

}