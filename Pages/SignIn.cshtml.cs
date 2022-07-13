using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CRUD_project.Model;
using CRUD_project;

namespace CRUD_project.Pages
{

    public class SignInModel : PageModel
    {
        [BindProperty]
        public User? User { get; set; }
        public IActionResult OnPost()
        {
            Service service = new Service();
            if (service.IsRegistered(User.Username,User.Password))
            {

                return RedirectToPage("/Users");
            }
            else
            {
                return Page(); // return to original page
            }
        }
        public List<User> users { get; set; }
        public void OnGet()
        {
            ViewData["Title"] = "Northwind B2B - Suppliers";

            using (var context = new user_managementContext())
            {
                users = context.Users.ToList();
            }
        }
    }
}