using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dto
{
    public class ListingDto
    {
        public int id { get; set; }
        public string listing_url { get; set; }
        public long scrape_id { get; set; }
        public DateTime? last_scraped { get; set; }
        public string name { get; set; }
        public string summary { get; set; }
        public string space { get; set; }
        public string description { get; set; }
        public string experiences_offered { get; set; }
        public string neighborhood_overview { get; set; }
        public string notes { get; set; }
        public string transit { get; set; }
        public string thumbnail_url { get; set; }
        public string medium_url { get; set; }
        public string picture_url { get; set; }
        public string xl_picture_url { get; set; }
        public int host_id { get; set; }
        public string host_url { get; set; }

        public string property_type { get; set; }
    }
}
