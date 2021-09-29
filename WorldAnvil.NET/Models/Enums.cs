using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public enum Template
    {
        Person = 1
    }
    public enum State
    {
        Public = 1,
        Private = 2
    }
    public enum RelationType
    {
        Collection = 0,
        Organization = 1,
        Timeline = 2,
        Singular = 3
    }
}
