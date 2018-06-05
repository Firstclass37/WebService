using System.Collections.Generic;
using System.Linq;
using DataModel.Interfaces;
using DataModel.Model;
using Newtonsoft.Json;
using RestSharp;

namespace DataModel.Implementation
{
    public class AlbumRemoteRepository : IAlbumRepository
    {
        private readonly RestClient _client = new RestClient("http://jsonplaceholder.typicode.com");

        public List<Album> GetAll()
        {
            var request = new RestRequest("albums");
            var response = _client.Execute(request).Content;
            return JsonConvert.DeserializeObject<List<Album>>(response);
        }

        public Album Get(int id)
        {
            var request = new RestRequest($"albums");
            request.AddQueryParameter("id", id.ToString());
            var response = _client.Execute(request).Content;
            return JsonConvert.DeserializeObject<List<Album>>(response).FirstOrDefault();
        }

        public List<Album> Search(int userId)
        {
            var request = new RestRequest("albums");
            request.AddQueryParameter("userId", userId.ToString());
            var response = _client.Execute(request).Content;
            return JsonConvert.DeserializeObject<List<Album>>(response);
        }
    }
}
