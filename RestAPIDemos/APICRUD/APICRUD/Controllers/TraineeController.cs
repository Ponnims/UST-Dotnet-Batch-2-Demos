using APICRUD.Exceptions;
using APICRUD.Models;
using APICRUD.Repository;
using APICRUD.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineeController : ControllerBase
    {
        private readonly ITraineeService svc;
        public TraineeController(ITraineeService svc)
        {
            this.svc = svc;
        }

        [HttpGet]
        public IActionResult GetTrainees()
        {
            var trainees = svc.GetTrainees();
            return Ok(trainees);
        }

        [HttpPost]
        public IActionResult CreateTrainee(Trainee trainee)
        {
            try
            {
                svc.CreateTrainee(trainee);
                return Ok("Trainee created successfully.");
            }
            catch (TraineeAlreadyExistsException ex)
            {
                return Conflict(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTrainee(int id, Trainee trainee)
        {
            try
            {
                svc.UpdateTrainee(id, trainee);
                return Ok("Trainee updated successfully.");
            }
            catch (Trainee_Doesnot_Exixts_Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTrainee(int id)
        {
            try
            {
                svc.DeleteTrainee(id);
                return Ok("Trainee deleted successfully.");
            }
            catch (Trainee_Doesnot_Exixts_Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
