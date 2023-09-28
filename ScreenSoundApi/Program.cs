using ScreenSoundApi.Filters;
using ScreenSoundApi.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string answer = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var music = JsonSerializer.Deserialize<List<Music>>(answer)!;
        //LinqFilter.TodosGeneros(music);
        LinqFilter.FiltrarArtistaPorGenero(music, "rock");
        //LinqOrder.ArtistasOrdenados(music);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"temos um problema: {ex.Message}");
    }
}