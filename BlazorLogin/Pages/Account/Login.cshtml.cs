using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using BlazorLogin.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BlazorLogin.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(ILogger<LoginModel> logger, IConfiguration config)
        {
            _logger = logger;
            configuration = config;
        }


        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = configuration.GetSection("SiteUser").Get<SiteUser>();
            if (ModelState.IsValid)
            {
                if (Input.Email == user.UserName)
                {
                    var passwordHasher = new PasswordHasher<string>();
                    if (passwordHasher.VerifyHashedPassword(null, user.Password, Input.Password) == PasswordVerificationResult.Success)
                    {
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Email, Input.Email)
                        };
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                        return Redirect("/FetchData");
                    }
                }
            }


            ModelState.AddModelError(string.Empty, "Email or password is incorrect.");
            return Page();
        }


    }
}