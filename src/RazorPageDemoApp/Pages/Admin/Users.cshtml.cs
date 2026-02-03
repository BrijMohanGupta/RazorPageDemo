using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

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
        var identityUsers = await _userManager.Users.ToListAsync();

        foreach (var user in identityUsers)
        {
            var roles = await _userManager.GetRolesAsync(user);

            Users.Add(new UserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                FullName = user.UserName,
                Roles = roles.ToList()
            });
        }
    }
}


public class UserViewModel
{
    public string Id { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string FullName { get; set; }
    public IList<string> Roles { get; set; } = new List<string>();
}
