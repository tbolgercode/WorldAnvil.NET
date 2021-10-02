using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class AnvilSearchOptions
    {
        public string Term;
        public int? Limit;
        public int? Offset;
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderBy OrderBy;
        [JsonConverter(typeof(StringEnumConverter))]
        public Trajectory Trajectory;
    }
}
