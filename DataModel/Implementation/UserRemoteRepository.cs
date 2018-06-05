using System.Collections.Generic;
using DataModel.Interfaces;
using DataModel.Model;
using Newtonsoft.Json;
using RestSharp;

namespace DataModel.Implementation
{
    public class UserRemoteRepository : IUserRepository
    {
        private readonly RestClient _client = new RestClient("http://jsonplaceholder.typicode.com");

        public List<User> GetAll()
        {
            var request = new RestRequest("users");
            var response = _client.Execute(request).Content;
            return JsonConvert.DeserializeObject<List<User>>(response);
        }

        public User Get(int id)
        {
            var request = new RestRequest($"users/{id}");
            request.AddQueryParameter("users", id.ToString());
            var response = _client.Execute(request).Content;
            return JsonConvert.DeserializeObject<User>(response);
        }
    }
}