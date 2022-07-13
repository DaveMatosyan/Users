using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_project.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public User? User { get; set; }
        public IActionResult OnPost()
        {
            Service service = new Service();
            if ((User is not null) && ModelState.IsValid)
            {
                service.PostUser(User);
                return RedirectToPage("/SignIn");
            }
            else
            {
                return Page(); // return to original page
            }
        }
        public void OnGet()
        {
        }
    }
}
