using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class AnvilUser
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Url { get; set; }
        public AnvilImage Avatar { get; set; }
    }
}
