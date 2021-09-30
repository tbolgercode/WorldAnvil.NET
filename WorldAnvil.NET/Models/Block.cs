using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class Block
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public AnvilItem Template { get; set; }
        public bool Shared { get; set; }
        public string Tags { get; set; }
        public object Data { get; set; }
        public AnvilItem World { get; set; }
        public AnvilUser Author { get; set; }
}
}
