using System.Data.Entity;

namespace PicturesGallery.Models
{
    public class PictureContext: DbContext
    {
        public DbSet<Picture> Pictures { get; set; }
    }
}