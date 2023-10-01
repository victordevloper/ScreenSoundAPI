using System.Text.Json.Serialization;

namespace ScreenSoundApi.Models;
internal class Music
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
    //Musica
    [JsonPropertyName("song")] 
    public string ?Name { get; set; }
    //Artista
    [JsonPropertyName("artist")]
    public string ?Artist { get; set; }
    //Duração
    [JsonPropertyName("duration_ms")] 
    public int ?Duration { get; set; }
    //Gênero
    [JsonPropertyName("genre")] 
    public string ?Genre { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public String Tonalidade 
    { 
        get 
        { 
            return tonalidades[Key];
        }
    }


    public void ExibirDetalhes()
    {
        Console.WriteLine($"Artista: {Artist}");
        Console.WriteLine($"Música: {Name}");
        Console.WriteLine($"Duração: {Duration / 1000}");
        Console.WriteLine($"Gênero: {Genre}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}
