using Microsoft.EntityFrameworkCore;

namespace APICRUD.Models
{
    public class TraineeDBContext:DbContext
    {
        public DbSet<Trainee> Trainees { get; set; }

        public TraineeDBContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
