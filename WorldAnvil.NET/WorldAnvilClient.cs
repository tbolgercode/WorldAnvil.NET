using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WorldAnvil.NET.Models;

namespace WorldAnvil.NET
{

    public class WorldAnvilClient : IWorldAnvilClient
    {
        private string BaseEndpoint;
        private string Apikey;
        private string Applicationkey;
        private HttpClient _client;
        public WorldAnvilClient(string apikey, string applicationkey, string endpoint = "https://www.worldanvil.com/api/aragorn/")
        {
            BaseEndpoint = endpoint;
            Apikey = apikey;
            Applicationkey = applicationkey;
            InitializeClient();
        }

        public bool DeleteArticle(Article article, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public bool DeleteArticle(string articleid, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public AnvilUser GetAnvilUser(string userid, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public AnvilUser GetAnvilUser(AnvilItem item, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public Article GetArticle(string articleid, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public Article GetArticle(AnvilItem item, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public Block GetBlock(string blockid, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public Block GetBlock(AnvilItem item, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public AnvilCategory GetCategory(string categoryid, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public AnvilCategory GetCategory(AnvilItem item, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public AnvilUser GetCurrentAnvilUser()
        {
            throw new NotImplementedException();
        }

        public AnvilImage GetImage(string imageid, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public AnvilImage GetImage(AnvilItem item, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public Manuscript GetManuscript(string manuscriptid, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public Manuscript GetManuscript(AnvilItem item, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public ManuscriptVersion GetManuscriptVersion(string manuscriptid, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public ManuscriptVersion GetManuscriptVersion(AnvilItem item, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public ManuscriptVersionExport GetManuscriptVersionExport(string manuscriptid, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public ManuscriptVersionExport GetManuscriptVersionExport(AnvilItem item, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public UserManuscripts GetUserManuscripts(string userid, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public UserManuscripts GetUserManuscripts(AnvilItem item, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public UserWorlds GetUserWorlds(string userid, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public UserWorlds GetUserWorlds(AnvilItem item, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public World GetWorld(string worldid, bool load_all_properties = false)
        {
            var response = _client.GetAsync($"world/{worldid}").Result;
            var test = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<World>(response.Content.ReadAsStringAsync().Result);

            //throw new NotImplementedException();
        }

        public World GetWorld(AnvilItem item, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public WorldArticles GetWorldArticles(string worldid, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public WorldArticles GetWorldArticles(AnvilItem item, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public WorldBlocks GetWorldBlocks(string idworldid, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public WorldBlocks GetWorldBlocks(AnvilItem item, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public WorldCategories GetWorldCategories(string worldid, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public WorldCategories GetWorldCategories(AnvilItem item, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public WorldImages GetWorldImages(string worldid, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public WorldImages GetWorldImages(AnvilItem item, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public void OverrideEndpoint(string url)
        {
            throw new NotImplementedException();
        }

        public Article PostArticle(Article article, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public WorldArticles SearchWorldArticles(string worldid, AnvilSearchOptions options, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public WorldArticles SearchWorldArticles(AnvilItem item, AnvilSearchOptions options, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public WorldBlocks SearchWorldBlocks(string worldid, AnvilSearchOptions options, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public WorldBlocks SearchWorldBlocks(AnvilItem item, AnvilSearchOptions options, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public WorldCategories SearchWorldCategories(string worldid, AnvilSearchOptions options, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public WorldCategories SearchWorldCategories(AnvilItem item, AnvilSearchOptions options, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public WorldImages SearchWorldImages(string worldid, AnvilSearchOptions options, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public WorldImages SearchWorldImages(AnvilItem item, AnvilSearchOptions options, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public void SetApplicationKey(string key)
        {
            throw new NotImplementedException();
        }

        public void SetToken(string token)
        {
            throw new NotImplementedException();
        }

        public Article UpdateArticle(Article article, bool load_all_properties = false)
        {
            throw new NotImplementedException();
        }

        public void ConfigureClient(string baseuri = null, string apikey = null, string applicationkey = null)
        {
            if (!string.IsNullOrEmpty(baseuri))
            {
                BaseEndpoint = baseuri;
            }
            if (!string.IsNullOrEmpty(apikey))
            {
                Apikey = apikey;
            }
            if (!string.IsNullOrEmpty(applicationkey))
            {
                Applicationkey = applicationkey;
            }
            InitializeClient();
        }

        public void InitializeClient()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(BaseEndpoint)
            };
            _client.DefaultRequestHeaders.Add("x-auth-token", Apikey);
            _client.DefaultRequestHeaders.Add("x-application-key", Applicationkey);
        }
    }
}
