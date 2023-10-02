class Podcast
{
    private List<Episodio> episodios =new List<Episodio>();
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public Podcast(Episodio ordem, Episodio duracao, Episodio titulo, Episodio resumo)
    {
        Ordem = ordem;
        Duracao = duracao;
        Titulo = titulo;
        Resumo = resumo;
    }

    public string Host {  get; }
    public string Nome { get;  }
    public Episodio Ordem {  get; }
    public Episodio Duracao { get; }
    public Episodio Titulo { get; }
    public Episodio Resumo { get; }

    public int TotalEpisodios => episodios.Count();

   

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} Apresentador: {Host}");
        foreach (var episodio in episodios)
        {
            Console.WriteLine($"\nEpisódio: {episodio.Ordem}");
            Console.WriteLine($"Duração: {episodio.Duracao}");
            Console.WriteLine($"Titulo: {episodio.Titulo}");
            Console.WriteLine($"Resumo: {episodio.Resumo}");
        }
        Console.WriteLine($"Total de episodios: {TotalEpisodios}");
    }

}