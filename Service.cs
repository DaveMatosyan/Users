using CRUD_project.Model;
namespace CRUD_project
{
    public class Service
    {
        public bool IsRegistered(string username, string password)
        {
            using (var context = new user_managementContext())
            {
                var users = context.Users.ToList();
                foreach(var user in users)
                {
                    if(user.Username == username && user.Password == password)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public List<User> GetUsers ()
        {
            using (var context = new user_managementContext())
            {
                return context.Users.ToList();
            }
        }
    }
}
