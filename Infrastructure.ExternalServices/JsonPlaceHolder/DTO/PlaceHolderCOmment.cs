using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ExternalServices.JsonPlaceHolder.DTO
{
    public class PlaceHolderComment
    {
        public int id { get; set; }
        public int postId { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
    }
}
