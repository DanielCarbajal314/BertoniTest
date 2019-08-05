using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service.Implementation;
using Services.Interfaces.Managers;
using Services.Interfaces.Request;

namespace Test.PlaceHolderIntegration
{
    [TestClass]
    public class RequestInformation
    {

        [TestMethod]
        public void GetAlbums()
        {
            IPhotoAlbumManager _PhotoAlbumManager = new PhotoAlbumManager();
            var albums = _PhotoAlbumManager.QueryAllAlbums();
            Assert.IsTrue(albums.Count > 0, "Server is not returning albums");
        }

        [TestMethod]
        public void GetPhotos()
        {
            IPhotoAlbumManager _PhotoAlbumManager = new PhotoAlbumManager();
            var photos = _PhotoAlbumManager.QueryCommentsFromPhoto(new QueryCommentsFromPhotoInformation() { PhotoId = 1});
            Assert.IsTrue(photos.Count > 0, "Server is not returning photos");
        }

        [TestMethod]
        public void GetComments()
        {
            IPhotoAlbumManager _PhotoAlbumManager = new PhotoAlbumManager();
            var comments = _PhotoAlbumManager.QueryPhotosFromAlbum(new QueryPhotosFromAlbumInformation() { AlbumId = 1 });
            Assert.IsTrue(comments.Count > 0, "Server is not returning comments");
        }
    }
}
