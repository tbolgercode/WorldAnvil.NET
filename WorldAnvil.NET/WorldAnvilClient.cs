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
            return DeleteArticle(article.Id, load_all_properties);
        }

        public bool DeleteArticle(string articleid, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.DeleteAsync($"article/{articleid}").Result;
            return true;
        }

        public AnvilUser GetAnvilUser(string userid, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.GetAsync($"user/{userid}").Result;
            return JsonConvert.DeserializeObject<AnvilUser>(response.Content.ReadAsStringAsync().Result);
        }

        public AnvilUser GetAnvilUser(AnvilItem item, bool load_all_properties = false)
        {
            return GetAnvilUser(item.Id, load_all_properties);
        }

        public Article GetArticle(string articleid, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.GetAsync($"article/{articleid}").Result;
            return JsonConvert.DeserializeObject<Article>(response.Content.ReadAsStringAsync().Result);
        }

        public Article GetArticle(AnvilItem item, bool load_all_properties = false)
        {
            return GetArticle(item.Id, load_all_properties);
        }

        public Block GetBlock(string blockid, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.GetAsync($"block/{blockid}").Result;
            return JsonConvert.DeserializeObject<Block>(response.Content.ReadAsStringAsync().Result);
        }

        public Block GetBlock(AnvilItem item, bool load_all_properties = false)
        {
            return GetBlock(item.Id, load_all_properties);
        }

        public AnvilCategory GetCategory(string categoryid, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.GetAsync($"category/{categoryid}").Result;
            return JsonConvert.DeserializeObject<AnvilCategory>(response.Content.ReadAsStringAsync().Result);
        }

        public AnvilCategory GetCategory(AnvilItem item, bool load_all_properties = false)
        {
            return GetCategory(item.Id, load_all_properties);
        }

        public AnvilUser GetCurrentAnvilUser(bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.GetAsync($"user").Result;
            return JsonConvert.DeserializeObject<AnvilUser>(response.Content.ReadAsStringAsync().Result);
        }

        public AnvilImage GetImage(string imageid, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.GetAsync($"image/{imageid}").Result;
            return JsonConvert.DeserializeObject<AnvilImage>(response.Content.ReadAsStringAsync().Result);
        }

        public AnvilImage GetImage(AnvilItem item, bool load_all_properties = false)
        {
            return GetImage(item.Id, load_all_properties);
        }

        public Manuscript GetManuscript(string manuscriptid, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.GetAsync($"manuscript/{manuscriptid}").Result;
            return JsonConvert.DeserializeObject<Manuscript>(response.Content.ReadAsStringAsync().Result);
        }

        public Manuscript GetManuscript(AnvilItem item, bool load_all_properties = false)
        {
            return GetManuscript(item.Id, load_all_properties);
        }

        public ManuscriptVersion GetManuscriptVersion(string manuscriptid, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.GetAsync($"manuscript/version/{manuscriptid}").Result;
            return JsonConvert.DeserializeObject<ManuscriptVersion>(response.Content.ReadAsStringAsync().Result);
        }

        public ManuscriptVersion GetManuscriptVersion(AnvilItem item, bool load_all_properties = false)
        {
            return GetManuscript(item.Id, load_all_properties);
        }

        public ManuscriptVersionExport GetManuscriptVersionExport(string manuscriptid, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.GetAsync($"manuscript/{manuscriptid}/export").Result;
            return JsonConvert.DeserializeObject<ManuscriptVersionExport>(response.Content.ReadAsStringAsync().Result);
        }

        public ManuscriptVersionExport GetManuscriptVersionExport(AnvilItem item, bool load_all_properties = false)
        {
            return GetManuscriptVersionExport(item.Id, load_all_properties);
        }

        public UserManuscripts GetUserManuscripts(string userid, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.GetAsync($"user/{userid}/manuscripts").Result;
            return JsonConvert.DeserializeObject<UserManuscripts>(response.Content.ReadAsStringAsync().Result);
        }

        public UserManuscripts GetUserManuscripts(AnvilItem item, bool load_all_properties = false)
        {
            return GetUserManuscripts(item.Id, load_all_properties);
        }

        public UserWorlds GetUserWorlds(string userid, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.GetAsync($"user/{userid}/worlds").Result;
            return JsonConvert.DeserializeObject<UserWorlds>(response.Content.ReadAsStringAsync().Result);
        }

        public UserWorlds GetUserWorlds(AnvilItem item, bool load_all_properties = false)
        {
            return GetUserWorlds(item.Id, load_all_properties);
        }

        public World GetWorld(string worldid, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.GetAsync($"world/{worldid}").Result;
            return JsonConvert.DeserializeObject<World>(response.Content.ReadAsStringAsync().Result);
        }

        public World GetWorld(AnvilItem item, bool load_all_properties = false)
        {
            return GetWorld(item.Id, load_all_properties);
        }

        public WorldArticles GetWorldArticles(string worldid, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.GetAsync($"world/{worldid}/articles").Result;
            return JsonConvert.DeserializeObject<WorldArticles>(response.Content.ReadAsStringAsync().Result);
        }

        public WorldArticles GetWorldArticles(AnvilItem item, bool load_all_properties = false)
        {
            return GetWorldArticles(item.Id, load_all_properties);
        }

        public WorldBlocks GetWorldBlocks(string worldid, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.GetAsync($"world/{worldid}/blocks").Result;
            return JsonConvert.DeserializeObject<WorldBlocks>(response.Content.ReadAsStringAsync().Result);
        }

        public WorldBlocks GetWorldBlocks(AnvilItem item, bool load_all_properties = false)
        {
            return GetWorldBlocks(item.Id, load_all_properties);
        }

        public WorldCategories GetWorldCategories(string worldid, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.GetAsync($"world/{worldid}/categories").Result;
            return JsonConvert.DeserializeObject<WorldCategories>(response.Content.ReadAsStringAsync().Result);
        }

        public WorldCategories GetWorldCategories(AnvilItem item, bool load_all_properties = false)
        {
            return GetWorldCategories(item.Id, load_all_properties);
        }

        public WorldImages GetWorldImages(string worldid, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var response = _client.GetAsync($"world/{worldid}/images").Result;
            return JsonConvert.DeserializeObject<WorldImages>(response.Content.ReadAsStringAsync().Result);
        }

        public WorldImages GetWorldImages(AnvilItem item, bool load_all_properties = false)
        {
            return GetWorldImages(item.Id, load_all_properties);
        }

        public void OverrideEndpoint(string url)
        {
            BaseEndpoint = url;
        }

        public Article PostArticle(Article article, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var content = new StringContent(JsonConvert.SerializeObject(article.AsPostArticle()));
            var response = _client.PostAsync($"article", content).Result;
            return JsonConvert.DeserializeObject<Article>(response.Content.ReadAsStringAsync().Result);
        }

        public WorldArticles SearchWorldArticles(string worldid, AnvilSearchOptions options, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties, options);
            var response = _client.GetAsync($"world/{worldid}/images").Result; 
            ResetSearchHeaders();
            return JsonConvert.DeserializeObject<WorldArticles>(response.Content.ReadAsStringAsync().Result);
        }

        public WorldArticles SearchWorldArticles(AnvilItem item, AnvilSearchOptions options, bool load_all_properties = false)
        {
            return SearchWorldArticles(item.Id, options, load_all_properties);
        }

        public WorldBlocks SearchWorldBlocks(string worldid, AnvilSearchOptions options, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties, options);
            var response = _client.GetAsync($"world/{worldid}/blocks").Result;
            ResetSearchHeaders();
            return JsonConvert.DeserializeObject<WorldBlocks>(response.Content.ReadAsStringAsync().Result);
        }

        public WorldBlocks SearchWorldBlocks(AnvilItem item, AnvilSearchOptions options, bool load_all_properties = false)
        {
            return SearchWorldBlocks(item.Id, options, load_all_properties);
        }

        public WorldCategories SearchWorldCategories(string worldid, AnvilSearchOptions options, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties, options);
            var response = _client.GetAsync($"world/{worldid}/categories").Result;
            ResetSearchHeaders();
            return JsonConvert.DeserializeObject<WorldCategories>(response.Content.ReadAsStringAsync().Result);
        }

        public WorldCategories SearchWorldCategories(AnvilItem item, AnvilSearchOptions options, bool load_all_properties = false)
        {
            return SearchWorldCategories(item, options, load_all_properties);
        }

        public WorldImages SearchWorldImages(string worldid, AnvilSearchOptions options, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties, options);
            var response = _client.GetAsync($"world/{worldid}/images").Result;
            ResetSearchHeaders();
            return JsonConvert.DeserializeObject<WorldImages>(response.Content.ReadAsStringAsync().Result);
        }

        public WorldImages SearchWorldImages(AnvilItem item, AnvilSearchOptions options, bool load_all_properties = false)
        {
            return SearchWorldImages(item.Id, options, load_all_properties);
        }

        public void SetApplicationKey(string key)
        {
            Applicationkey = key;
        }

        public void SetToken(string token)
        {
            Apikey = token;
        }

        public Article UpdateArticle(Article article, bool load_all_properties = false)
        {
            SetPropertiesHeader(load_all_properties);
            var content = new StringContent(JsonConvert.SerializeObject(article.AsPostArticle()));
            var response = _client.PatchAsync($"article/{article.Id}", content).Result;
            return article;
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
            _client.DefaultRequestHeaders.Add("load_all_properties", "false");
        }

        private void SetPropertiesHeader(bool load_all_properties, AnvilSearchOptions searchOptions = null)
        {
            _client.DefaultRequestHeaders.Remove("load_all_properties");
            _client.DefaultRequestHeaders.Add("load_all_properties", load_all_properties ? "true" : "false");

            ResetSearchHeaders();

            if(searchOptions != null)
            {
                SetSearchHeaders(searchOptions);
            }
            
        }

        private void ResetSearchHeaders()
        {
            _client.DefaultRequestHeaders.Remove("term");
            _client.DefaultRequestHeaders.Remove("offset");
            _client.DefaultRequestHeaders.Remove("order_by");
            _client.DefaultRequestHeaders.Remove("trajectory");
        }

        private void SetSearchHeaders(AnvilSearchOptions searchOptions)
        {
            _client.DefaultRequestHeaders.Add("term",  searchOptions.Term);
            _client.DefaultRequestHeaders.Add("offset", searchOptions.Offset != null ? searchOptions.Offset.ToString() : "0");
            _client.DefaultRequestHeaders.Add("order_by", searchOptions.OrderBy.ToString());
            _client.DefaultRequestHeaders.Add("trajectory", searchOptions.Trajectory.ToString());
        }
    }
}
