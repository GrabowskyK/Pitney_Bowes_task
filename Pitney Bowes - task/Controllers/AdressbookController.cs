using Microsoft.AspNetCore.Mvc;
using Pitney_Bowes___task.Model;
using Pitney_Bowes___task.Service;

namespace Pitney_Bowes___task.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdressbookController : ControllerBase
    {
        private readonly IAdressbookService addressbookService;
        private readonly ILogger<AdressbookController> logger;

        public AdressbookController(ILogger<AdressbookController> _logger, IAdressbookService _addressbookService)
        {
            logger = _logger;
            addressbookService = _addressbookService;
        }

        [HttpGet("GetLastAddress")]
        public IActionResult GetLastAddress()
        {
            var model = addressbookService.GetLastAddress();
            if(model == null)
            {
                LogFullRequest();
                logger.LogWarning("Book is empty!");
                return BadRequest("Book is empty!");
            }
            LogFullRequest();
            return Ok(model);
        }

        [HttpGet("GetAddressesInCity")]
        public IActionResult GetAddressesInCity(string cityName)
        {
            var model = addressbookService.GetAddressesInCity(cityName);
            if(model == null)
            {
                LogFullRequest();
                logger.LogWarning("There is not any address in city or city name is wrong!");
                return BadRequest("There is not any address in city or city name is wrong!");
            }
            LogFullRequest();
            return Ok(model);
        }

        [HttpPost("AddAddress")]
        public ActionResult<Address> AddAddress(Address newAddress)
        {
            addressbookService.AddAddress(newAddress);
            LogFullRequest();
            return Ok();
        }

        private void LogFullRequest()
        {
            string loggingInfo = "";
            var request = HttpContext.Request;
            logger.LogInformation("\n");
            

            foreach (var (key, value) in request.Headers)
            {
                loggingInfo += $"{key}: {value} \n";
                
            }
            logger.LogInformation($"" +
                $"Request Path: {request.Path} " +
                $"\n Method: {request.Method} " +
                $"\n Headers: {loggingInfo}");

        }
    }
}
