class Musica
{

    public Musica(Banda NomeBanda, string nome,Genero NomeGenero)
    {
        Artista = NomeBanda;
        Nome = nome;
        nomeGenero = NomeGenero;

    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero nomeGenero { get; }

public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista.NomeBanda}\n";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Artista: {Artista.NomeBanda}");
        Console.WriteLine($"Duracão: {Duracao}");
        Console.WriteLine($"Genero: {nomeGenero.NomeGenero}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");

        }
        else 
        { 
            Console.WriteLine("Adquira o plano plus+"); 
        }
        Console.WriteLine(DescricaoResumida);

    }
}