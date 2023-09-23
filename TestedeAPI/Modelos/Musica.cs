using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestedeAPI.Modelos;

internal class Musica
{
    [JsonPropertyNameAttribute("song")]
    public string? Nome { get; set; }
    [JsonPropertyNameAttribute("artist")]
    public string? Artista{ get; set; }
    [JsonPropertyNameAttribute("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyNameAttribute("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica() 
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao/1000} seg");
        Console.WriteLine($"Genêro: {Genero}");

        ;
    }
}
