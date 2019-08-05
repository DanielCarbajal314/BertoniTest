using Services.Interfaces.Managers;
using Services.Interfaces.Request;
using Services.Interfaces.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentation.Web.Controllers
{
    public class PhotoAlbumController : ApiController
    {
        private IPhotoAlbumManager _photoAlbumManager;

        public PhotoAlbumController(IPhotoAlbumManager photoAlbumManager)
        {
            this._photoAlbumManager = photoAlbumManager;
        }

        [HttpGet]
        public List<Album> Albums()
        {
            return this._photoAlbumManager.QueryAllAlbums();
        }

        [HttpGet]
        public List<Comment> CommentsFromPhoto([FromUri]QueryCommentsFromPhotoInformation query)
        {
            return this._photoAlbumManager.QueryCommentsFromPhoto(query);
        }

        [HttpGet]
        public List<Photo> PhotosFromAlbum([FromUri]QueryPhotosFromAlbumInformation query)
        {
            return this._photoAlbumManager.QueryPhotosFromAlbum(query);
        }
    }
}
