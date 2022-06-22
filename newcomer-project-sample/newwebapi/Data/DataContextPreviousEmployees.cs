namespace newwebapi.Data
{
    public class DataContextPreviousEmployees: DbContext
    {
        public DataContextPreviousEmployees(DbContextOptions<DataContextPreviousEmployees> options) : base(options){}

        public DbSet<PreviousEmployee> PreviousEmployees { get; set; }
    }
} 