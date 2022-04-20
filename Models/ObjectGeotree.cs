using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public class ObjectGeotree
    {
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("objectId")]
        public Guid ObjectId { get; set; }

        [JsonProperty("externalSource")]
        public string ExternalSource { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("identifierName")]
        public string IdentifierName { get; set; }

        [JsonProperty("geom")]
        public GeoInfo Geom { get; set; }

        [JsonProperty("center")]
        public Center Center { get; set; }

        [JsonProperty("bbox")]
        public Bbox Bbox { get; set; }
    }

    public class Bbox
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public List<List<List<double>>> Coordinates { get; set; }
    }

    public class Center
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public List<double> Coordinates { get; set; }
    }

    public class GeoInfo
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public List<List<List<List<double>>>> Coordinates { get; set; }
    }
}