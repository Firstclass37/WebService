using System.Collections.Generic;
using DataModel.Model;

namespace DataModel.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();

        User Get(int id);
    }
}