using ContactManagerProject.Models;
using ContactManagerProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagerProject.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userService.GetAllUsersAsync();
            return View(users);
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            await _userService.UploadUsersAsync(file);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromBody] User user)
        {
            if (!ModelState.IsValid) return View("Index", await _userService.GetAllUsersAsync());

            await _userService.EditUserAsync(user);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _userService.GetAllUsersAsync();
            if (user == null) return NotFound();

            await _userService.DeleteUserAsync(id);
            return RedirectToAction("Index");
        }
    }
}