namespace oop_alura;

public class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public string Host { get; }
    public string Nome { get; }
    private int TotalEpisodios => episodios.Count;

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Lista de episódios do podcast {Nome} apresentado por {Host}\n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"{episodio.Resumo}");
        }

        Console.WriteLine($"\n\nEste podcast possui {TotalEpisodios} episódios.");
    }
}