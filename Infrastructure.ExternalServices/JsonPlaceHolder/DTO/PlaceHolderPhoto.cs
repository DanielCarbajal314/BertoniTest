using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ExternalServices.JsonPlaceHolder.DTO
{
    public class PlaceHolderPhoto
    {
        public int id { get; set; }
        public int albumId { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }

    }
}
