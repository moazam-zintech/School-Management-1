using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School_Management_System.Data;
using School_Management_System.Models;
using System.Threading.Tasks;

public class UserController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly TokenService _tokenService;

    public UserController(ApplicationDbContext context, TokenService tokenService)
    {
        _context = context;
        _tokenService = tokenService;
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register([FromBody] Register model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        // Check if the user already exists
        var existingUser = await _context.Register
            .FirstOrDefaultAsync(u => u.Username == model.Username || u.Email == model.Email);

        if (existingUser != null)
        {
            return BadRequest("User already exists.");
        }

        var user = new Register
        {
            Username = model.Username,
            Email = model.Email,
            Password = model.Password,
            Role = model.Role,
            Address = model.Address,
            PhoneNumber = model.PhoneNumber,
            ConfirmPassword = model.ConfirmPassword,

        };

        _context.Register.Add(user);
        await _context.SaveChangesAsync();

        return RedirectToAction("Login");
    }

    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Login([FromBody] Login model)
    {
        var user = await _context.Register.FirstOrDefaultAsync(u => u.Email == model.Email);

        if (user == null || user.Password != model.Password) 
        {
            return Unauthorized("Invalid credentials.");
        }

        var token = _tokenService.GenerateToken(user.Email);
        return Ok(new { Token = token, Message = "Login successful." });
    }
}