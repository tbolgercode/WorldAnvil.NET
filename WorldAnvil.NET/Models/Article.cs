using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class Article
    {
        public string Id;
        public string Title;
        public TemplateType Template;
        public bool IsWip;
        public bool IsDraft;
        public bool IsAdultContent;
        public State State;
        public string Passcode;
        public int Wordcount;
        public string ArticleParent;
        public string Parent;
        public AnvilImage Cover;
        public AnvilDate CreationDate;
        public AnvilDate UpdateDate;
        public AnvilDate PublicationDate;
        public object NotificationDate;
        public string Tags;
        public string Seeded;
        public string SideBarContent;
        public string SidePanelContentTop;
        public string SidePanelContent;
        public string SideBarContentBottom;
        public string Footnotes;
        public string FullFooter;
        public string AuthorNotes;
        public string Credits;
        public string Scrapbook;
        public string Excerpt;
        public string Pronunciation;
        public string Subheading;
        public string Icon;
        public int Position;
        public string Url;
        public AnvilItem Category;
        public AnvilItem World;
        public AnvilItem Author;
        public AnvilImage Portrait;
        public object Content;
        public string Content_Parsed;
        public List<KeyValuePair<string, Section>> Sections;
        public List<KeyValuePair<string, Relation>> Relations;
        public Relation RelatedOrganizations;
        public object UserMetadata;
    }
}
