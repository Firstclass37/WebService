using System.Collections.Generic;
using System.Web.Http;
using DataModel.Implementation;
using DataModel.Interfaces;
using DataModel.Model;

namespace WebService.Controllers
{
    public class AlbumController : ApiController
    {
        private readonly IAlbumRepository _albumRepository = new AlbumRemoteRepository();

        [HttpGet]
        public List<Album> GetAll()
        {
            return _albumRepository.GetAll();
        }

        [HttpGet]
        public Album Get(int id)
        {
            return _albumRepository.Get(id);
        }

        [HttpGet]
        public List<Album> Search(int userId)
        {
            return _albumRepository.Search(userId);
        }
    }
}