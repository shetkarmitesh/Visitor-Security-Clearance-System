using Microsoft.AspNetCore.Mvc;
using Visitor_Security_Clearance_System.DTO;
using Visitor_Security_Clearance_System.Interfaces;

namespace Visitor_Security_Clearance_System.Controllers
{
    public class RegistrationController : Controller
    {
        public readonly IRegistrationService _registrationService; //object of interface

        public RegistrationController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }
    }
}
