using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Response
{
    public class Photo
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string URL { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}
