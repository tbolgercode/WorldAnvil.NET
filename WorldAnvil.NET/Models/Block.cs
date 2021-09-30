using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class Block
    {
        public ulong Id;
        public string Name;
        public AnvilItem Template;
        public bool Shared;
        public string Tags;
        public object Data;
        public AnvilItem World;
        public AnvilUser Author;
    }
}
