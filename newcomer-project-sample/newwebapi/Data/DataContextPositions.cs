namespace newwebapi.Data
{
    public class DataContextPositions: DbContext
    {
        public DataContextPositions(DbContextOptions<DataContextPositions> options) : base(options){}

        public DbSet<Position> Positions { get; set; }
    }
} 