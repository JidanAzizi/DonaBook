using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonaBookApi.Services;
using DonaBookApi.Model;


namespace DonaBookApi.Services
{
    public interface IUserService
    {
        void LoadUsers();
        User? Authenticate(string email, string password);
        List<User> GetAllUsers();
    }
}

