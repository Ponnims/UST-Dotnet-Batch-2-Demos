using APICRUD.Models;
using APICRUD.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineeController : ControllerBase
    {
        private readonly ITraineeRepository repo;
        public TraineeController(ITraineeRepository repo)
        {
            this.repo=repo;
        }
        [HttpGet]
        public IActionResult GetTrainees()
        {
            return Ok(repo.GetTrainees());
        }

        [HttpPost]
        public IActionResult CreateTrainee(Trainee trainee)
        {
            repo.CreateTrainee(trainee);
            return StatusCode(201,"Trainee created successfully");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTrainee(int id,Trainee trainee)
        {
            repo.UpdateTrainee(id,trainee);
            return Ok("Trainee updated successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTrainee(int id)
        {
            repo.DeleteTrainee(id);
            return Ok("Trainee deleted successfully");
        }
    }
}
