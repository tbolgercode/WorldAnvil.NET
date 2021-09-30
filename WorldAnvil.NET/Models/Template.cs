using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class Template
    {
        public string Id;
        public string Title;
        public State State;
        public int? Views;
        public string Description;
        public string Excerpt;
        public string Icon;
        public int Postion;
        public string Url;
        public AnvilItem PageCover;
        public AnvilItem BookCover;
        public AnvilItem ParentCategory;
        public AnvilItem World;
    }
}
