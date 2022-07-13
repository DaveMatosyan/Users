using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CRUD_project.Model;
using CRUD_project;

namespace CRUD_project.Pages
{
    public class UsersModel : PageModel
    {
        public List<User> users { get; set; }
        public void OnGet()
        {
            ViewData["Title"] = "Northwind B2B - Suppliers";

            Service service = new Service();
            users = service.GetUsers();
        }
    }
}
