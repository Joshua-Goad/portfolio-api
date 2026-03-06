using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        public class ContactForm
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Message { get; set; }
        }

        [HttpPost]
        public IActionResult Submit(ContactForm form)
        {
            if (string.IsNullOrWhiteSpace(form.Name) ||
                string.IsNullOrWhiteSpace(form.Email) ||
                string.IsNullOrWhiteSpace(form.Message))
            {
                return BadRequest("All fields are required.");
            }

            // Future: send email, save to DB, etc.
            return Ok(new { success = true, message = "Message received." });
        }
    }
}
