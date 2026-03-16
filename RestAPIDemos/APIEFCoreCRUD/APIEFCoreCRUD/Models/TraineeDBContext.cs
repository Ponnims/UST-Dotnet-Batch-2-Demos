using Microsoft.EntityFrameworkCore;

namespace APIEFCoreCRUD.Models
{
    public class TraineeDBContext:DbContext
    {
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public TraineeDBContext(DbContextOptions options):base(options) 
        {
            

        }

    }
}
