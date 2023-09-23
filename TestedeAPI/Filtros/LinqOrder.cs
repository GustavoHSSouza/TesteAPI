using System.Linq;
using TestedeAPI.Modelos;
namespace TestedeAPI.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistaOrdenados(List<Musica> musicas) 
        {
            var artistiasOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musica => musica.Artista).Distinct().ToList();
            foreach (var artista in artistiasOrdenados)
            {
                Console.WriteLine($"-{artista}");
            }
        }
    }
}
