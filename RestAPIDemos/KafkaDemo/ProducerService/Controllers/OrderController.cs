using Confluent.Kafka;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProducerService.Models;
using System.Text.Json.Serialization;

namespace ProducerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IConfiguration config;
        public OrderController(IConfiguration config)
        {
            this.config = config;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Order order)
        {
            // make ur message ready
            string message = JsonConvert.SerializeObject(order);
            // Configure Kafka Producer
            ProducerConfig pconfig = new ProducerConfig
            {
                BootstrapServers = config["Kafka:Server"]
            };
            // CReate and Build the Kafka Producer

            using (var producer= new ProducerBuilder<Null,string>(pconfig).Build())
            {
                await producer.ProduceAsync("test", new Message<Null, string>
                {
                    Value = message
                });
                return await Task.FromResult(Ok("Message sent to Kafa"));
            }
        }
    }
}
