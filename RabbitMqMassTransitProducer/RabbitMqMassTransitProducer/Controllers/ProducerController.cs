using MassTransit;
using MassTransitExchange;
using Microsoft.AspNetCore.Mvc;

namespace RabbitMqMassTransitProducer.Controllers
{
    [Route("api/v1/producer")]
    [ApiController]
    public class ProducerController : ControllerBase
    {
        private IPublishEndpoint _publishEndpoint;

        public ProducerController(IPublishEndpoint publish)
        {
            _publishEndpoint = publish;
        }

        [HttpPost]
        public async Task<IActionResult> InsertMessage([FromBody] int idMensagem, string descricao)
        {
            await _publishEndpoint.Publish<MensagemEntity>(new()
            {
                IdMensagem = idMensagem,
                Descricao = descricao
            });

            return Ok("Mensagem publicada com sucesso");
        }
    }
}
