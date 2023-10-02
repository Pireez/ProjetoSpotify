class Episodio
{
    public Episodio(Podcast host, Podcast nome)
    {
        Host = host;
        Nome = nome;
    }

    public Podcast Host { get; }
    public Podcast Nome { get; }
    public int Ordem { get; set; }
    public int Duracao { get; set; }
    public string Titulo { get; set; }
    public string Resumo => 
        $"O episódio de número {Ordem} - {Titulo} com duração de {Duracao}";
    
    
    public void AdicionarConvidados()
    {



    }


}