using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class Template
    {
        public string Id { get; set; }
        public string Title { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public State State { get; set; }
        public int? Views { get; set; }
        public string Description { get; set; }
        public string Excerpt { get; set; }
        public string Icon { get; set; }
        public int Postion { get; set; }
        public string Url { get; set; }
        public AnvilItem PageCover { get; set; }
        public AnvilItem BookCover { get; set; }
        public AnvilItem ParentCategory { get; set; }
        public AnvilItem World { get; set; }
    }
}
