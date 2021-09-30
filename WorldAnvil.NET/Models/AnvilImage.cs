using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class AnvilImage
    {
        public ulong Id;
        public string Title;
        public State State;
        public string Url;
        public string Description;
        public string Tags;
        public double Size;
        public double Width;
        public double Height;
        public string Extension;
        public AnvilItem World;
        public AnvilUser Author;
    }
}
