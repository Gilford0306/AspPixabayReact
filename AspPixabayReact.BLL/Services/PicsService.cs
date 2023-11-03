using AspPixabayReact.BLL.DTO;
using AspPixabayReact.BLL.Entities;
using AspPixabayReact.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace AspPixabayReact.BLL.Services
{
    public class PicsService : IPicsService
    {
        private string requrestURL;
        private List<PicsDTO>? Hits { get; set; }

        public PicsService()
        {
            requrestURL = @"https://pixabay.com/api/?key=39207646-8ccbcc7ff50179f772c7bccff&q=";
            Hits = new List<PicsDTO>();
        }

        public async Task<ActionResult<IEnumerable<PicsDTO>>> GetAllHitsAsync(string? request)
        {
            request = string.IsNullOrEmpty(request) ? "Ukraine" : request;
            WebClient wc = new WebClient();
            string tmp = await wc.DownloadStringTaskAsync(new Uri($"{requrestURL}{request}"));
            List<Pic> tempHits = new List<Pic>(JsonSerializer.Deserialize<PicsRepository>(tmp).hits);
            tempHits.ForEach(hit => Hits.Add(new PicsDTO(hit)));
            if (Hits == null) return null;
            return Hits;
        }
    }
}
