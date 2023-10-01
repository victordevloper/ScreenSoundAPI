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
}
