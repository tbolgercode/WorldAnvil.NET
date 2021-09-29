using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class Relation
    {
        public string Id;
        public string Title;
        public string Position;
        public string Type;
        public bool Is_Article;
        public State State;
        public List<AnvilItem> Items;
    }
}
