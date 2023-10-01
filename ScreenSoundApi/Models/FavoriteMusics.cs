using System.Text.Json;

namespace ScreenSoundApi.Models;
internal class FavoriteMusics
{
    public string ?Name {  get; set; }
    public List<Music> FavListMusic { get; }

    public FavoriteMusics(string name) 
    {
        Name = name;
        FavListMusic = new List<Music>();
    }

    public void AdicionarMusicasFav(Music music)
    {
        FavListMusic.Add(music);
    }

    public void ExibirMusicasFav()
    {
        Console.WriteLine($"---Essas são as musicas favoritas de {Name}---\n");
        foreach(var music in FavListMusic)
        {
            Console.WriteLine(music.Name);
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Name,
            music = FavListMusic
        });

        string arquivoJson = $"musicas-favoritas-{Name}.json";

        File.WriteAllText(arquivoJson, json);
        Console.WriteLine($"Arquivo Json criado com sucesso. {Path.GetFullPath(arquivoJson)}");
    }
}
