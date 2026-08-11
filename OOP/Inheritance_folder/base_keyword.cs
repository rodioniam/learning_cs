namespace Learning_C_;


public static class BaseKeyword
{
    public static void Result()
    {
        Album album = new("YellowClaw", "Blood For Mercy");
        Track track = new("Yellow Claw", "Blood For Mercy", "Trap");

        track.GetTrackInfo();
    }
}


class Album
{
    public string AuthorName { get; set; }
    public string AlbumName { get; set; }


    public Album(string authorName, string albumName)
    {
        AuthorName = authorName;
        AlbumName = albumName;
    }

    public void GetAlbumInfo()
    {
        Console.WriteLine("Album author is: " + AuthorName);
        Console.WriteLine("Album name is: " + AlbumName);
    }
}


class Track : Album
{
    public string TrackName { get; set; }
    public Track(string authorName, string albumName, string trackName) : base(authorName, albumName) // так передается конструктор класса
    {
        TrackName = trackName;
    }

    public void GetTrackInfo()
    {
        base.GetAlbumInfo(); // так я взял метод из родительского класса, его использование не обязательно
        Console.WriteLine("Track name is: " + TrackName);
    }
}