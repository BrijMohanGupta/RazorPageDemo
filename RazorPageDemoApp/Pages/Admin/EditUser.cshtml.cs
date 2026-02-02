using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageDemoApp.Pages.Admin
{
    public class EditUserModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public EditUserModel(UserManager<IdentityUser> userManager,
        RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [BindProperty] public string UserId { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<string> AllRoles { get; set; } = new();
        public IList<string> UserRoles { get; set; } = new List<string>();

        [BindProperty] public List<string> SelectedRoles { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();


            UserId = user.Id;
            Email = user.Email!;
            UserRoles = await _userManager.GetRolesAsync(user);
            AllRoles = _roleManager.Roles.Select(r => r.Name!).ToList();


            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.FindByIdAsync(UserId);
            if (user == null) return NotFound();


            var currentRoles = await _userManager.GetRolesAsync(user);


            await _userManager.RemoveFromRolesAsync(user, currentRoles);
            await _userManager.AddToRolesAsync(user, SelectedRoles);


            return RedirectToPage("Users");
        }
    }
}
