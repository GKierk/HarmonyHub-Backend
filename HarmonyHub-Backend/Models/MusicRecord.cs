namespace HarmonyHub_Backend.Models;

public class MusicRecord
{
    public string Title { get; set; }

    public string Artist { get; set; }

    public int PublicationYear { get; set; }
    
    // Duration in Seconds
    public int Duration { get; set;}
    
    public override string ToString()
    {
        return $"Title: {Title}, Artist: {Artist}, Publication Year: {PublicationYear}, Duration in Seconds: {Duration}";
    }

    public void VerifyTitle()
    {
        if (string.IsNullOrEmpty(Title))
        {

        }
    }
}
