using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class AnvilCategory : AnvilItem
    {
        public State State;
        public double Views;
        public string Description;
        public string Excerpt;
        public string Icon;
        public double Position;
        public AnvilImage PageCover;
        public AnvilImage BookCover;
        public AnvilItem ParentCategory;
        public AnvilItem World;
    }
}
