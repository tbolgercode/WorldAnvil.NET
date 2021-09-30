using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class Manuscript : ManuscriptVersion
    {
        public Status Status;
        public string Slug;
        public string Description;
        public string DescriptionParsed;
        public double Likes;
        public double Views;
        public double Words;
        public AnvilItem World;
        public AnvilImage Cover;
        public AnvilUser Author;
        public List<ManuscriptVersion> ActiveVersion;
        public List<ManuscriptVersion> Versions;
    }

    public class ManuscriptVersion
    {
        public string Id;
        public string Title;
        public State State;
    }
}
