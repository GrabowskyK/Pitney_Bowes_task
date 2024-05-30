using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using Pitney_Bowes___task.Controllers;
using Pitney_Bowes___task.Model;
using Pitney_Bowes___task.Service;

namespace PitneyBowes.Tests
{
    public class AdressbookControllerTest
    {
        private readonly Mock<IAdressbookService> mockAddressbookService;
        private readonly Mock<ILogger<AdressbookController>> mockLogger;
        private readonly AdressbookController controller;

        public AdressbookControllerTest()
        {
            mockAddressbookService = new Mock<IAdressbookService>();
            mockLogger = new Mock<ILogger<AdressbookController>>();
            controller = new AdressbookController(mockLogger.Object, mockAddressbookService.Object);
        }
    }
}