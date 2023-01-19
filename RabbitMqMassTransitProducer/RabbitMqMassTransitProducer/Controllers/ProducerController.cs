using Microsoft.AspNetCore.Mvc;

namespace RabbitMqMassTransitProducer.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class ProducerController : ControllerBase
    {
        [HttpPost("producer")]
        public async Task<IActionResult> InsertMessage()
        {
            return Ok();
        }
    }
}
