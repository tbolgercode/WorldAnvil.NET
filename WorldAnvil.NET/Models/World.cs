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

    public class WorldItemBase : AnvilSearchOptions
    {
        public World World;
    }

    public class WorldArticles : WorldItemBase
    {
        public List<Article> Articles;
    }

    public class WorldBlocks : WorldItemBase
    {
        public List<Block> Blocks;
    }

    public class WorldImages : WorldItemBase
    {
        public List<AnvilImage> Images;
    }

    public class WorldCategories : WorldItemBase
    {
        public List<AnvilCategory> Categories;
    }
}
