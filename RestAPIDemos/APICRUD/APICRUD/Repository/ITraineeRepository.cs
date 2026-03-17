using APICRUD.Models;

namespace APICRUD.Repository
{
    public interface ITraineeRepository
    {
        List<Trainee> GetTrainees();
        Trainee GetTrainee(int id);
        void CreateTrainee(Trainee trainee);
        void UpdateTrainee(int id,Trainee trainee);
        void DeleteTrainee(int id);
    }
}
