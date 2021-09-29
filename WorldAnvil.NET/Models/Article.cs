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
        public string Template;
        public bool Is_Wip;
        public bool Is_Draft;
        public string Passcode;
        public int Wordcount;
        public AnvilDate Creation_Date;
        public AnvilDate Update_Date;
        public AnvilDate Publication_Date;
        public object Notification_Date;
        public string Tags;
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
    }
}
