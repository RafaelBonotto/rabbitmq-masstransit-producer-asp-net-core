using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace RabbitMqMassTransitProducer.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class ProducerController : ControllerBase
    {
        private IPublishEndpoint _publish;

        public ProducerController(IPublishEndpoint publish)
        {
            _publish = publish;
        }

        [HttpPost("producer")]
        public async Task<IActionResult> InsertMessage()
        {
            return Ok();
        }
    }
}
