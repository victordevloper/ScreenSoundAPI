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
        //LinqFilter.FiltrarArtistaPorGenero(music, "rock");
        //LinqFilter.FitrarMusicaporArtista(music, "Arctic Monkeys");
        //LinqOrder.ArtistasOrdenados(music);
        //music[1].ExibirDetalhes();

        //var minhasFavoritas = new FavoriteMusics("Victor");

        //minhasFavoritas.AdicionarMusicasFav(music[1]);
        //minhasFavoritas.AdicionarMusicasFav(music[15]);
        //minhasFavoritas.AdicionarMusicasFav(music[876]);
        //minhasFavoritas.AdicionarMusicasFav(music[134]);
        //minhasFavoritas.AdicionarMusicasFav(music[505]);

        //minhasFavoritas.ExibirMusicasFav();
        //minhasFavoritas.GerarArquivoJson();

        LinqFilter.FiltrarMusicaEmCSharp(music);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"temos um problema: {ex.Message}");
    }
}