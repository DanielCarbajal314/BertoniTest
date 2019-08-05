using Infrastructure.ExternalServices.JsonPlaceHolder;
using Service.Implementation.Extensions;
using Services.Interfaces.Managers;
using Services.Interfaces.Request;
using Services.Interfaces.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class PhotoAlbumManager : IPhotoAlbumManager
    {
        private JsonPlaceHolderClient _jsonPlaceHolderClient = new JsonPlaceHolderClient();

        public List<Album> QueryAllAlbums()
        {
            return _jsonPlaceHolderClient.GetAllAlbums().Select(x => x.ToServiceResponseContract()).ToList();
        }

        public List<Comment> QueryCommentsFromPhoto(QueryCommentsFromPhotoInformation query)
        {
            return _jsonPlaceHolderClient.GetCommentsWithPhotoId(query.PhotoId).Select(x => x.ToServiceResponseContract()).ToList();
        }

        public List<Photo> QueryPhotosFromAlbum(QueryPhotosFromAlbumInformation query)
        {
            return _jsonPlaceHolderClient.GetPhotoWithAlbumId(query.AlbumId).Select(x => x.ToServiceResponseContract()).ToList();
        }
    }
}
