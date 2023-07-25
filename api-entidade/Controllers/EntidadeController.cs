using Microsoft.AspNetCore.Mvc;

namespace api_entidade.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntidadeController : ControllerBase
    {
        private readonly ILogger<EntidadeController> _logger;

        public EntidadeController(ILogger<EntidadeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetEntidade")]
        [EventoPersonalizado("Exemplo de annotation personalizada")]
        public String Get()
        {
            _logger.LogInformation("Init Get");

            return "Teste Paulo";
        }
    }
}