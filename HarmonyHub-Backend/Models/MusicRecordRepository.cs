namespace HarmonyHub_Backend.Models;

public class MusicRecordRepository
{
    public List<MusicRecord>? MusicRecords { get; set; }

    public MusicRecordRepository()
    {
        Initialize();
    }

    private void Initialize()
    {
        MusicRecords = new List<MusicRecord>
        {
            new MusicRecord { Id = 1, Title = "Piano Concerto no 2", Artist = "Rachmaninoff", PublicationYear = 1958, Duration = 2280 },
            new MusicRecord { Id = 2, Title = "Meteora" , Artist = "Linkin Park" , PublicationYear = 2003 , Duration = 2160}

        };
    }

    public MusicRecord Create(MusicRecord musicRecord)
    {
        if (MusicRecords.Count == 0)
        {
            musicRecord.Id = 1;
        }
        else
        {
            musicRecord.Id = MusicRecords.Count + 1;
        }

        MusicRecords.Add(musicRecord);
        return musicRecord;
    }

    public IEnumerable<MusicRecord> Read(string? title=null, string artist=null )
    {
        IQueryable<MusicRecord> query = MusicRecords.AsQueryable();

        if ( title != null )
        {
            query = query.Where(m => m.Title == title);
        }
        if ( artist != null )
        {
            query = query.Where(m => m.Artist == artist);
        }

        return query;
    }

    public MusicRecord? Update(int id, MusicRecord musicRecord)
    {
        musicRecord.Id = id;
        MusicRecord? recordToUpdate = MusicRecords.Find(r => r.Id == musicRecord.Id);
        if (recordToUpdate == null)
        {
            return null;
        }

        int recordIndeex = musicRecord.Id;
        MusicRecords[--recordIndeex] = musicRecord;

        return recordToUpdate;
    }
    
    public MusicRecord? Delete(int id)
    {
        MusicRecord? recordToDelete = MusicRecords.Find(r => r.Id == id);

        if (recordToDelete == null)
        {
            return null;
        }

        MusicRecords.Remove(recordToDelete);
        return recordToDelete;
    }
}
