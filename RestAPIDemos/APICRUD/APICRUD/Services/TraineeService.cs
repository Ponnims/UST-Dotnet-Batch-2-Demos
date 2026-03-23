using APICRUD.Exceptions;
using APICRUD.Models;
using APICRUD.Repository;

namespace APICRUD.Services
{
    public class TraineeServicee : ITraineeService
    {
        private readonly ITraineeRepository repo;

        public TraineeServicee(ITraineeRepository repo)
        {
            this.repo = repo;
        }
        public void CreateTrainee(Trainee trainee)
        {
            var traineeFromDB = repo.GetTrainee(trainee.Id);
            if (traineeFromDB == null)
            {
                repo.CreateTrainee(trainee);
            }
            else
            {
                throw new TraineeAlreadyExistsException($"Trainee with ID {trainee.Id} already exists.");
            }
        }

        public void DeleteTrainee(int id)
        {
            var traineeFromDB = repo.GetTrainee(id);
            if (traineeFromDB == null)
            {
                throw new Trainee_Doesnot_Exixts_Exception($"Trainee with ID {id} not found.");
            }
            else
            {
                repo.DeleteTrainee(id);
            }
        }

        public List<Trainee> GetTrainees()
        {
            return repo.GetTrainees();
        }

        public void UpdateTrainee(int id, Trainee trainee)
        {
            var traineeFromDB = repo.GetTrainee(id);
            if (traineeFromDB == null)
            {
                throw new Trainee_Doesnot_Exixts_Exception($"Trainee with ID {id} not found.");
            }
            else
            {
                repo.UpdateTrainee(id, trainee);
            }
        }
    }
}
