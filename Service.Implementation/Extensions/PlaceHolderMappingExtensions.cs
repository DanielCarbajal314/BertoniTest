using Infrastructure.ExternalServices.JsonPlaceHolder.DTO;
using Services.Interfaces.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation.Extensions
{
    internal static class PlaceHolderMappingExtensions
    {
        public static Photo ToServiceResponseContract(this PlaceHolderPhoto placeHolderPhoto)
        {
            return new Photo()
            {
                Id = placeHolderPhoto.id,
                ThumbnailUrl = placeHolderPhoto.thumbnailUrl,
                Tittle = placeHolderPhoto.title,
                URL = placeHolderPhoto.url
            };
        }

        public static Comment ToServiceResponseContract(this PlaceHolderComment placeHolderComment)
        {
            return new Comment()
            {
                Id = placeHolderComment.id,
                Body = placeHolderComment.body,
                Email = placeHolderComment.email,
                Name = placeHolderComment.name
            };
        }

        public static Album ToServiceResponseContract(this PlaceHolderAlbum placeHolderAlbum)
        {
            return new Album()
            {
                Id = placeHolderAlbum.id,
                Tittle = placeHolderAlbum.title
            };
        }
    }
}
