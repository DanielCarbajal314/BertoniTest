using Infrastructure.ExternalServices.JsonPlaceHolder.DTO;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ExternalServices.JsonPlaceHolder
{
    public class JsonPlaceHolderClient
    {
        private RestClient client = new RestClient("https://jsonplaceholder.typicode.com");
        public List<PlaceHolderPhoto> GetPhotoWithAlbumId(int albumId)
        {
            var request = new RestRequest("photos", Method.GET);
            request.AddParameter("albumId", albumId);
            return client.Execute<List<PlaceHolderPhoto>>(request).Data;
        }

        public List<PlaceHolderComment> GetCommentsWithPhotoId(int photoId)
        {
            var request = new RestRequest("comments", Method.GET);
            request.AddParameter("postId", photoId);
            return client.Execute<List<PlaceHolderComment>>(request).Data;
        }

        public List<PlaceHolderAlbum> GetAllAlbums()
        {
            var request = new RestRequest("albums", Method.GET);
            return client.Execute<List<PlaceHolderAlbum>>(request).Data;
        }
    }
}
