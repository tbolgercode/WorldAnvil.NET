﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class AnvilItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
        public ItemType Type { get; set; }
        public AnvilItem System { get; set; }
        public AnvilImage Avatar { get; set; }
        public AnvilImage Image { get; set; }
        public List<KeyValuePair<string, AnvilItem>> Children { get; set; }
    }
}
