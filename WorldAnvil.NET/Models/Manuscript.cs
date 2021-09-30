using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class Manuscript : ManuscriptVersion
    {
        public string Slug { get; set; }
        public string Description { get; set; }
        public string DescriptionParsed { get; set; }
        public double Likes { get; set; }
        public double Views { get; set; }
        public double Words { get; set; }
        public AnvilItem World { get; set; }
        public AnvilImage Cover { get; set; }
        public AnvilUser Author { get; set; }
        public List<ManuscriptVersion> ActiveVersion { get; set; }
        public List<ManuscriptVersion> Versions { get; set; }
    }

    public class ManuscriptVersion
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public State State { get; set; }
        public Status Status { get; set; }
    }
}
