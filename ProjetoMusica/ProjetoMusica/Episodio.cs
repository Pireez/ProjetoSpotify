class Episodio
{
    private List<string> convidados = new List<string>();
 

    public Episodio(int ordem, int duracao, string titulo)
    {
        Ordem = ordem;
        Duracao = duracao;
        Titulo = titulo;
    }

    public Podcast Host { get; }
    public Podcast Nome { get; }
    public int Ordem { get; }
    public int Duracao { get; }
    public string Titulo { get; }
    public string Resumo =>
        $"{Ordem} - {Titulo} com duração de {Duracao} - " +
        $"Convidados: {string.Join(", ", convidados)}";
    
    
    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);

    }


}