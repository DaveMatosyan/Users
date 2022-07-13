

namespace CRUD_project
{
    public class Bcrypt
    {
        public string Hash(string str)
        {
            return BCrypt.Net.BCrypt.HashPassword(str);
        }
        public bool Verify(string Password, string HashedPassword)
        {
            System.Diagnostics.Debug.WriteLine(Password);
            System.Diagnostics.Debug.WriteLine(HashedPassword);
            return BCrypt.Net.BCrypt.Verify(Password, HashedPassword);
        }
    }
}
