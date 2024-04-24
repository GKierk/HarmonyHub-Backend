namespace HarmonyHub_Backend.Models;

public class MusicRecord
{
    public string? Title { get; set; }

    public string? Artist { get; set; }

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
            throw new ArgumentNullException("Title can't be empty.");
        }
    }

    public void VerifyArtist()
    {
        if (string.IsNullOrEmpty(Artist))
        {
            throw new ArgumentNullException("Artist can't be empty.");
        }
    }

    public void VerifyPublicationYear()
    { 
        if (PublicationYear > DateTime.Now.Year)
        {
            throw new ArgumentOutOfRangeException("Publication year can't be after the current year.");
        }

        if (PublicationYear < 1930)
        {
            // First vinyl record was made in 1930.
            throw new ArgumentOutOfRangeException("The year must be after 1929.");
        }
    }

    public void VerifyDuration()
    {
        if (Duration < 0)
        {
            throw new ArgumentOutOfRangeException("Duration must be greater than 0.");
        }
    }

    public void Verify()
    {
        VerifyTitle();
        VerifyArtist();
        VerifyPublicationYear();
        VerifyDuration();
    }
}
