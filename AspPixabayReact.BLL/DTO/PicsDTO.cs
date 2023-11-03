using AspPixabayReact.BLL.Entities;

namespace AspPixabayReact.BLL.DTO
{
    public class PicsDTO
    {
        public int id { get; set; }
        public string largeImageURL { get; set; }
        public string imageURL { get; set; }
        public int imageWidth { get; set; }
        public int imageHeight { get; set; }
        public int imageSize { get; set; }

        public PicsDTO(Pic hit)
        {
            id = hit.id;
            largeImageURL = hit.largeImageURL;
            imageURL = hit.imageURL;
            imageWidth = hit.imageWidth;
            imageHeight = hit.imageHeight;
            imageSize = hit.imageSize;
        }
    }
}
