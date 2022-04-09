using System;
using Newtonsoft.Json;

namespace Covid.Models
{
    public partial class Prefectures
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name_ja")]
        public string NameJa { get; set; }

        [JsonProperty("name_en")]
        public string NameEn { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("cases")]
        public long Cases { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }
    }

    

public class Total
	{

	}
	public class Positives
	{

	}

}

