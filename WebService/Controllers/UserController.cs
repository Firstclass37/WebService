using System.Collections.Generic;
using System.Web.Http;
using DataModel.Implementation;
using DataModel.Interfaces;
using DataModel.Model;

namespace WebService.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserRepository _userRepository = new UserRemoteRepository();

        [HttpGet]
        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        [HttpGet]
        public User Get(int id)
        {
            return _userRepository.Get(id);
        }
    }
}