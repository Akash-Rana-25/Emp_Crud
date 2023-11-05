using Microsoft.AspNetCore.Mvc;
using Employee_Managment.Models;
using Employee_Managment.Repository;

namespace Employee_Managment.Controllers
{
    public class PunchEventsController : Controller
    {
        private readonly IPunchEventRepository _punchEventRepository;

        public PunchEventsController(PunchEventRepository punchEventRepository)
        {
            _punchEventRepository = punchEventRepository;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PunchEvent punchEvent)
        {
            if (ModelState.IsValid)
            {
                _punchEventRepository.CreatePunchEventAsync(punchEvent).Wait();
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                // Handle validation errors
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                return BadRequest(new { success = false, message = "Validation error: " + string.Join(", ", errors.Select(e => e.ErrorMessage)) });
            }
            return View(punchEvent);
        }

    }
}
