using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public class AnvilDate
    {
        public DateTime Date { get; set; }
        //TODO: Use TimezoneInfo
        public int Timezone_type { get; set; }
        public string Timezone { get; set; }
    }
}
