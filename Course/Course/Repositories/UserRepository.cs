using Course.Models;

namespace Course.Repositories
{
    public class UserRepository
    {
        private static List<User> users = new List<User> { new User { Id = 1, FirstName = "john", LastName = "Nagy" } };
        public List<User> GetAll() { return users; }

        public User? GetById(int id)
        {
            foreach (var user in users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }
        public void Create(User data)
        {
            users.Add(data);
        }
        public User? Update(int id, User data)
        {
            foreach(var user in users)
            {
                if (user.Id == id)
                {
                    user.FirstName = data.FirstName;
                    user.LastName = data.LastName;
                    return user;

                }
            }
            return null;
        }
        public bool delete(int id)
        {
            foreach(var user in users)
            {
                if (user.Id == id)
                {
                    users.Remove(user);
                    return true;
                }
            }
            return false;
        }
    }
}
