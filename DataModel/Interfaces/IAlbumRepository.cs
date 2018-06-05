using System.Collections.Generic;
using DataModel.Model;

namespace DataModel.Interfaces
{
    public interface IAlbumRepository
    {
        List<Album> GetAll();

        Album Get(int id);

        List<Album> Search(int userId);
    }
}