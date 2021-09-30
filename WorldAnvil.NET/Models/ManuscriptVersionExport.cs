using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class ManuscriptVersionExport
    {
        public ManuscriptVersion Manuscript { get; set; }
        public ManuscriptVersion Version { get; set; }
        public List<KeyValuePair<string, AnvilItem>> Parts {get;set;}

    }
}
