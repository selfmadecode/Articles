using Api.Interfaces;
using Api.Model;

namespace Api.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly Database _database;

        public UserRepository(Database database)
        {
            _database = database;
        }


        public void AddUser(string username)
        {

        }
    }
}
