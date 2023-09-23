using System.Text.Json;
using TestedeAPI.Filtros;
using TestedeAPI.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        //LinqOrder.ExibirListaDeArtistaOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Travis Scott");
        var musicasPreferidasDoGuga = new MusicasPreferidas("Guga");
        musicasPreferidasDoGuga.AdicionarMusicasFavoritas(musicas[66]);
        musicasPreferidasDoGuga.AdicionarMusicasFavoritas(musicas[465]);
        musicasPreferidasDoGuga.AdicionarMusicasFavoritas(musicas[285]);
        musicasPreferidasDoGuga.AdicionarMusicasFavoritas(musicas[1000]);
        musicasPreferidasDoGuga.AdicionarMusicasFavoritas(musicas[895]);

        musicasPreferidasDoGuga.ExibirMusicaFavorita();
        musicasPreferidasDoGuga.GerarArquivosJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}