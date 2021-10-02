using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class Relation
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public string Type { get; set; }
        public bool Is_Article { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public State State { get; set; }
        public List<AnvilItem> Items { get; set; }
    }
}
