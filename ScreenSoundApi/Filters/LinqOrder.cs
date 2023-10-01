using ScreenSoundApi.Models;
using System.Linq;

namespace ScreenSoundApi.Filters;
internal class LinqOrder
{
    public static void ArtistasOrdenados(List<Music> musics)
    {
        var artistsOrders = musics.OrderBy(musics => musics.Artist).Select(music => music.Artist).Distinct().ToList();

        Console.WriteLine("---Artistas Ordenados---");
        foreach (var artist in artistsOrders)
        {
            Console.WriteLine($"Artista - {artist}");
        }
    }
}
