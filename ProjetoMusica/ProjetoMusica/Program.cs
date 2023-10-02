Episodio ep1 = new(2, 45, "Tecnicas de facilitação");
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Roberto");

Episodio ep2 = new(1, 60, "Tecnicas de aprendizado");
ep2.AdicionarConvidados("fernando");
ep2.AdicionarConvidados("flavia");

Podcast podcast = new("Gustavo", "PodPah");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);

podcast.ExibirDetalhes();
