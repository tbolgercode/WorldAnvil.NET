using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class World : AnvilItem
    {
        public State State;
        public string Name;
        public string Locale;
        public string Description;
        public string DescriptionParsed;
        public string DisplayCss;
        public int Theme;
        public string Tags;
        public AnvilImage Cover;
        public AnvilUser Author;
    }

    public class WorldItemBase
    {
        public World World;
        public string Offset;
        public int Limit;
    }

    public class WorldArticles : WorldItemBase
    {
        public string Term;
        public string OrderBy;
        public string Trajectory;
        public List<Article> Articles;
    }

    public class WorldBlocks : WorldItemBase
    {
        public List<Block> Blocks;
    }

    public class WorldImages : WorldItemBase
    {
        public string OrderBy;
        public string Trajectory;
        public List<AnvilImage> Images;
    }
}
