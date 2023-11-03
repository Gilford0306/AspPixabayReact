namespace AspPixabayReact.BLL.Entities
{
    public class PicsRepository
    {
        public int total { get; set; }
        public int totalHits { get; set; }
        public List<Pic> hits { get; set; }
    }
}
