using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageDemoApp.Pages.Admin;
public class UsersModel : PageModel
{
    private readonly UserManager<IdentityUser> _userManager;


    public UsersModel(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }


    public List<UserViewModel> Users { get; set; } = new();


    public async Task OnGetAsync()
    {
        foreach (var user in _userManager.Users)
        {
            Users.Add(new UserViewModel
            {
                Id = user.Id,
                Email = user.Email!,
                Roles = await _userManager.GetRolesAsync(user)
            });
        }
    }
}


public class UserViewModel
{
    public string Id { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public IList<string> Roles { get; set; } = new List<string>();
}
