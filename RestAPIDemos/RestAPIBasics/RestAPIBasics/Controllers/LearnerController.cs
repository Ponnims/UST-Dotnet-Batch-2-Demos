using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPIBasics.Models;

namespace RestAPIBasics.Controllers
{
    [Route("api/ust/[controller]")]
    [ApiController]
    public class LearnerController : ControllerBase
    {
        [HttpGet]
        [Route("getlearnerss")]
        public IActionResult GetLearners()
        {
            var learners = new List<string> { "Alice", "Bob", "Charlie" };
            return Ok(learners);
        }

        [HttpGet("anotherget")]

        public IActionResult AnotherGet()
        {
            return Ok("This is another GET endpoint.");
        }

        [HttpGet("getlearnerbyid/{id}")]
        public IActionResult GetLearnerById(int id)
        {
            var learner = $"Learner {id}";
            return Ok(learner);
        }

        [HttpGet("methodwithquerystr")]
        public IActionResult methodwithquerystr([FromQuery]string input)
        {
            // example: api/ust/learner/methodwithquerystr?input=hello
            return Ok($"You entered: {input}");
        }

        [HttpGet("methodwithquerystrlearnerdata")]
        public IActionResult methodwithquerystrl([FromBody] Learner data)
        {
            // example: api/ust/learner/methodwithquerystr?input=hello
            return Ok($"You entered: Id: {data.Id},Name:  {data.Name}, Stream: {data.Stream}, Score: {data.Score}");
        }

        [HttpPost("postlearnerdata")]
        public ActionResult<Learner> postlearnerdata([FromBody] Learner data)
        {
            // example: api/ust/learner/methodwithquerystr?input=hello
            return Ok($"You entered: Id: {data.Id},Name:  {data.Name}, Stream: {data.Stream}, Score: {data.Score}");
        }
    }
}
