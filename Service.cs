using CRUD_project.Model;
namespace CRUD_project
{
    public class Service
    {
        Bcrypt bcrypt = new Bcrypt();
        public bool IsRegistered(string username, string password)
        {
            using (var context = new user_managementContext())
            {
                var users = context.Users.ToList();
                foreach(var user in users)
                {
                    if(user.Username == username && bcrypt.Verify(password, user.Password))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public List<User> GetUsers()
        {
            using (var context = new user_managementContext())
            {
                return context.Users.ToList();
            }
        }
        public void PostUser(User user)
        {
            using (var context = new user_managementContext())
            {
                user.Password = bcrypt.Hash(user.Password);

                context.Add(user);
                context.SaveChanges();
            }
        }
    }
}
