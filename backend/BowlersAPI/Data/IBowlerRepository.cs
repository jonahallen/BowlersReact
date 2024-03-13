namespace BowlersAPI.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
    }
}
