using APICRUD.Models;

namespace APICRUD.Repository
{
    public class TraineeRepository : ITraineeRepository
    {
        private readonly TraineeDBContext dbcntxt;

        public TraineeRepository(TraineeDBContext dbcntxt)
        {
            this.dbcntxt=dbcntxt;
        }
        public void CreateTrainee(Trainee trainee)
        {
            dbcntxt.Add(trainee);
            dbcntxt.SaveChanges();
        }

        public void DeleteTrainee(int id)
        {
            var traineetobedeleted = dbcntxt.Trainees.Where(t => t.Id == id).FirstOrDefault();
            dbcntxt.Trainees.Remove(traineetobedeleted);
            dbcntxt.SaveChanges();
        }

        public List<Trainee> GetTrainees()
        {
            return dbcntxt.Trainees.ToList();
        }

        public void UpdateTrainee(int id, Trainee trainee)
        {
            var traineetobeupdated = dbcntxt.Trainees.Where(t => t.Id == id).FirstOrDefault();
            traineetobeupdated.Name=trainee.Name;
            traineetobeupdated.Technology=trainee.Technology;
            traineetobeupdated.Score=trainee.Score;
            dbcntxt.SaveChanges();

        }
    }
}
