using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using TestedeAPI.Filtros;
namespace TestedeAPI.Modelos;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }
    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicaFavorita()
    {
        Console.WriteLine($"Essas são as músicas favoritas");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"-{musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivosJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
         string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Arquivo Json Criado com Sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}
