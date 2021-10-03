using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class PostArticle
    {
        public string world { get; set; }
        public string title { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TemplateType Template { get; set; }
        public bool   isWip { get; set; }
        public bool   isDraft { get; set; }
        public bool   isAdultContent { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public State  state { get; set; }
        public string category { get; set; }
        public string articleParent { get; set; }
        public string parent { get; set; }
        public int    cover { get; set; }
        public string content { get; set; }
        public string tags { get; set; }
        public string seeded { get; set; }
        public string sidebarcontent { get; set; }
        public string sidepanelcontentTop { get; set; }
        public string sidepanelcontent { get; set; }
        public string sidebarcontentbottom { get; set; }
        public string footnotes { get; set; }
        public string fullfooter { get; set; }
        public string authornotes { get; set; }
        public string credits { get; set; }
        public string scrapbook { get; set; }
        public string excerpt { get; set; }
        public string pronunciation { get; set; }
        public string subheading { get; set; }
        public string icon { get; set; }
        public int    position { get; set; }
        public object userMetadata { get; set; }

    }
}
