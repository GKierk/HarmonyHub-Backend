namespace HarmonyHub_Backend.Models;

public class MusicRecordRepository
{
    public List<MusicRecord> MusicRecords { get; set; } = new List<MusicRecord>();

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

    public IEnumerable<MusicRecord> Read()
    {
        IQueryable<MusicRecord> query = MusicRecords.AsQueryable();

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
}
