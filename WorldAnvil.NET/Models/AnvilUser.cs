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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string DeviantArt { get; set; }
        public string Youtube { get; set; }
        public string Twitch { get; set; }
        public string Discord { get; set; }
        public string Instagram { get; set; }
        public string Kofi { get; set; }
        public string Patreon { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Reddit { get; set; }
        public string Locale { get; set; }
        public bool Membership { get; set; }
        public string MembershipType { get; set; }
        public string Url { get; set; }
        public AnvilDate RegistrationDate { get; set; }
        public AnvilImage Avatar { get; set; }
    }

    public class UserManuscripts
    {
        public string Id;
        public string Username;
        public List<Manuscript> Manuscripts;
    }

    public class UserWorlds
    {
        public string Id;
        public string Username;
        public List<World> Worlds;
    }
}
