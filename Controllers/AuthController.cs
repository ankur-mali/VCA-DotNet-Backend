using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using VCA.Models;
using VCA.Services.Registrations;


namespace VCA.Controllers
{

    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IRegistrationRepository _registrationService;

        public AuthController(IRegistrationRepository registrationService)
        {
            _registrationService = registrationService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Registration company)
        {
            try
            {
                // Authenticate the user here and generate a JWT token upon successful login
                // You should replace this with your actual authentication logic

                // If authentication is successful, generate a JWT token
                // string jwtToken = GenerateJwtToken(loginRequest.Username); // Replace with your token generation logic
                Registration existComp = await _registrationService.FindByUsernameAsync(company.Email);
                if (existComp == null || existComp.Password != company.Password)
                {
                    return BadRequest("Invalid Credential");
                }

                var responseData = new Dictionary<string, object>
                {
                    { "status", "success" }
                    // Add token if needed
                };

                return Ok(responseData);
            }
            catch (Exception e)
            {
                // Handle authentication failure
                var errorResponse = new Dictionary<string, object>
                {
                    { "status", "error" },
                    { "message", "Authentication failed" } // Customize this message
                };
                return StatusCode(StatusCodes.Status401Unauthorized, errorResponse);
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] Registration registration)
        {
            try
            {
                // Implement your registration logic here
                var existingRegistration = await _registrationService.FindByUsernameAsync(registration.Email);
                if (existingRegistration != null)
                {
                    return BadRequest("Username already exists");
                }

                // Implement your validation logic if needed
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                await _registrationService.CreateRegistrationAsync(registration);

                return Ok("Registration successful");
            }
            catch (Exception e)
            {
                var errorResponse = new Dictionary<string, object>
                {
                    { "status", "error" },
                    { "message", "Authentication failed" }
                };
                return StatusCode(StatusCodes.Status400BadRequest, errorResponse);
            }
        }
    }
}
