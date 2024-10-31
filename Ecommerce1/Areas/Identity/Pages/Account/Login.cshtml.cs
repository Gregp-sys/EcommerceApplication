using Ecommerce1.Data;
using Ecommerce1.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

public class LoginModel : PageModel
{
    private readonly SignInManager<AppUsers> _signInManager;
    private readonly UserManager<AppUsers> _userManager;
    private readonly ILogger<LoginModel> _logger;
    private readonly ApplicationDbContext _context;

    public LoginModel(SignInManager<AppUsers> signInManager,
                      UserManager<AppUsers> userManager,
                      ILogger<LoginModel> logger,
                      ApplicationDbContext context)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _logger = logger;
        _context = context;
    }

    [BindProperty]
    public InputModel Input { get; set; }

    public IList<AuthenticationScheme> ExternalLogins { get; private set; }

    public string ReturnUrl { get; set; }

    public class InputModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public async Task OnGetAsync(string returnUrl = null)
    {
        ReturnUrl = returnUrl ?? Url.Content("~/");
        await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
        ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
    }

    public async Task<IActionResult> OnPostAsync(string returnUrl = null)
    {
        ReturnUrl = returnUrl ?? Url.Content("~/");

        if (ModelState.IsValid)
        {
            var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(Input.Email);
                _logger.LogInformation("User logged in.");

                await InitializeShoppingSessionAsync(user.Id_Appuser);

                return LocalRedirect(ReturnUrl);
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt. Please check your email and password and try again.");
        }

        ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        return Page();
    }

    private async Task InitializeShoppingSessionAsync(int id_Appuser)
    {
        try
        {
            // Check if a shopping session already exists for the user
            var existingSession = await _context.ShoppingSessions
                .FirstOrDefaultAsync(s => s.Id_AppUser == id_Appuser && s.Modified == null);

            // If no session exists, create a new one
            if (existingSession == null)
            {
                var shoppingSession = new Shopping_Session
                {
                    Id_AppUser = id_Appuser,
                    Total_price = 0,
                    Created = DateTime.UtcNow,
                    Modified = null
                };

                _context.ShoppingSessions.Add(shoppingSession);
                await _context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while initializing the shopping session for user {UserId}", id_Appuser);
            throw; // Optionally handle or rethrow the exception
        }
    }
}
