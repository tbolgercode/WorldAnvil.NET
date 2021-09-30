using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class Article
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public TemplateType Template { get; set; }
        public bool IsWip { get; set; }
        public bool IsDraft { get; set; }
        public bool IsAdultContent { get; set; }
        public State State { get; set; }
        public string Passcode { get; set; }
        public int Wordcount { get; set; }
        public string ArticleParent { get; set; }
        public string Parent { get; set; }
        public AnvilImage Cover { get; set; }
        public AnvilDate CreationDate { get; set; }
        public AnvilDate UpdateDate { get; set; }
        public AnvilDate PublicationDate { get; set; }
        public object NotificationDate { get; set; }
        public string Tags { get; set; }
        public string Seeded { get; set; }
        public string SideBarContent { get; set; }
        public string SidePanelContentTop { get; set; }
        public string SidePanelContent { get; set; }
        public string SideBarContentBottom { get; set; }
        public string Footnotes { get; set; }
        public string FullFooter { get; set; }
        public string AuthorNotes { get; set; }
        public string Credits { get; set; }
        public string Scrapbook { get; set; }
        public string Excerpt { get; set; }
        public string Pronunciation { get; set; }
        public string Subheading { get; set; }
        public string Icon { get; set; }
        public int Position { get; set; }
        public string Url { get; set; }
        public AnvilItem Category { get; set; }
        public AnvilItem World { get; set; }
        public AnvilItem Author { get; set; }
        public AnvilImage Portrait { get; set; }
        public object Content { get; set; }
        public string Content_Parsed { get; set; }
        public List<KeyValuePair<string, Section>> Sections { get; set; }
        public List<KeyValuePair<string, Relation>> Relations { get; set; }
        public Relation RelatedOrganizations { get; set; }
        public object UserMetadata { get; set; }
    }
}
