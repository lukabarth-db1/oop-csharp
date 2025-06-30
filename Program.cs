using oop_alura;

Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicasDoAlbum();

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();

// Arquivos do podcast

Episodio ep1 = new(45, 1, "Técnicas de facilitação");
ep1.AdicionarConvidados("Luka Barth");
ep1.AdicionarConvidados("Guilherme Silveira");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(45, 2, "Técnicas de aprendizado");
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flavia");

Podcast podcast = new("Daniel", "Podcast especial");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();