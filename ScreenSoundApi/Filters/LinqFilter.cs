using ScreenSoundApi.Models;
using System.Linq;

namespace ScreenSoundApi.Filters;
internal class LinqFilter
{
    public static void TodosGeneros(List<Music> musics)
    {
        var allgenres = musics.Select(genres => genres.Genre).Distinct().ToList();
        
        foreach (var genre in allgenres)
        {
            Console.WriteLine($"- {genre}");
        }
    }
    public static void FiltrarArtistaPorGenero(List<Music> musics, string genre)
    {
        var artistsForGenre = musics.Where(musics => musics.Genre!.Contains(genre)).Select(musics => musics.Artist).Distinct().ToList();

        Console.WriteLine("---Exibindo Artistas Por Gênero---\n");
        foreach(var artist in artistsForGenre)
        {
            Console.WriteLine($"Artista - {artist}");
        }
    }

    public static void FitrarMusicaporArtista(List<Music> musics, string artistName)
    {
        var artistMusic = musics.Where(musics => musics.Artist!.Equals(artistName)).ToList();

        Console.WriteLine($"Musicas de {artistName}");
        foreach(var music in artistMusic)
        {
            Console.WriteLine($"- {music.Name}");
        }
    }
}
