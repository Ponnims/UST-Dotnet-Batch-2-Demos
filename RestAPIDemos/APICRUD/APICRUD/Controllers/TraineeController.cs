using APICRUD.Exceptions;
using APICRUD.Models;
using APICRUD.Repository;
using APICRUD.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //[AllowAnonymous] // This allows access to all endpoints in this controller without authentication.
    //Remove if you want to enforce authentication.
    public class TraineeController : ControllerBase
    {
        private readonly ITraineeService svc;
        public TraineeController(ITraineeService svc)
        {
            this.svc = svc;
        }

        [HttpGet]
      //  [Authorize(Roles = "Trainee")]
        public IActionResult GetTrainees()
        {
            var trainees = svc.GetTrainees();
            return Ok(trainees);
        }

        [HttpPost]
        //[Authorize(Roles = "Trainer")]
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
        //[Authorize(Roles = "Trainer")]
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
        //[Authorize(Roles = "Trainer")]
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
