using Services.Interfaces.Request;
using Services.Interfaces.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Managers
{
    public interface IPhotoAlbumManager
    {
        List<Album> QueryAllAlbums();
        List<Photo> QueryPhotosFromAlbum(QueryPhotosFromAlbumInformation query);
        List<Comment> QueryCommentsFromPhoto(QueryCommentsFromPhotoInformation query);
    }
}
