namespace TestsNotes.Domain
{
    public interface IHasId<TKey>
    {
        TKey Id { get; set; }
    }
}
