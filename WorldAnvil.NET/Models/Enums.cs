using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAnvil.NET.Models
{
    public enum OrderBy
    {
        Id = 0,
        Title = 1,
        NotificationDate = 2,
        CreationDate = 3
    }
    public enum Trajectory
    {
        Asc = 0,
        Desc = 1
    }
    public enum ItemType
    {
        Text = 0,
        Folder = 1,
        Image = 2
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
    public enum TemplateType
    {
        Article = 0,
        Person = 1,
        MilitaryConflict = 2,
        Condition = 3,
        Document = 4,
        Ethnicity = 5,
        Formation = 6,
        Location = 7,
        Item = 8,
        Language = 9,
        Law = 10,
        Settlement = 11,
        Landmark = 12,
        Material = 13,
        Myth = 14,
        Organization = 15,
        Prose = 16,
        Profession = 17,
        Rank = 18,
        Spell = 19,
        Species = 20,
        Technology = 21,
        Ritual = 22,
        Vehicle = 23
    }
    public enum Status
    {
        Ongoing = 0,
        Completed = 1
    }

}
