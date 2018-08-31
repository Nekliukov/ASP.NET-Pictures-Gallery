using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PicturesGallery.Models
{
    public class Picture
    {
        public int ID { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
    }
}