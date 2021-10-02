using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class AnvilSearchOptions
    {
        public string Term;
        public int? Limit;
        public int? Offset;
        public OrderBy OrderBy;
        public Trajectory Trajectory;
    }
}
