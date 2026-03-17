using APICRUD.Models;

namespace APICRUD.Services
{
    public interface ITraineeService
    {
        void CreateTrainee(Trainee trainee);
        void UpdateTrainee(int id, Trainee trainee);
        void DeleteTrainee(int id);
        List<Trainee> GetTrainees();
    }
}
