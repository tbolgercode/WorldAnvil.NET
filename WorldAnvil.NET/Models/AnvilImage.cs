using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class AnvilImage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public State State { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public double Size { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public string Extension { get; set; }
        public AnvilItem World { get; set; }
        public AnvilUser Author { get; set; }
    }
}
