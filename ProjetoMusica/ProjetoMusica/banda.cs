class Banda
{

    private List<Album> albums = new List<Album>();

    public Banda(string Nome)
    {
        NomeBanda = Nome;
    }

    public string NomeBanda { get;}

    public void AdicionarAlbum(Album album)
    {
        {
            albums.Add(album);  
        }
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {NomeBanda}");
        foreach(Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})\n");
        }

    }
}