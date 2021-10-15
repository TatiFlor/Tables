using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Razor_test1.Models
{
    public class Row
    {
        [JsonPropertyName("Time_Windows")]
        public string Time { get; set; }

        [JsonPropertyName("1m")]
        public int one_m { get; set; }
        [JsonPropertyName("5m")]
        public int five_m { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Row>(this);
        
    }
}
