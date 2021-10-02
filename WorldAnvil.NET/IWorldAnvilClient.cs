using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WorldAnvil.NET.Models;

namespace WorldAnvil.NET
{
    public interface IWorldAnvilClient
    {
        public void SetToken(string token);
        public void SetApplicationKey(string key);
        public Article GetArticle(string articleid, bool load_all_properties = false);
        public Article GetArticle(AnvilItem item, bool load_all_properties = false);
        public string PostArticle(Article article, bool load_all_properties = false);
        public Article UpdateArticle(Article article, bool load_all_properties = false);
        public bool DeleteArticle(Article article, bool load_all_properties = false);
        public bool DeleteArticle(string articleid, bool load_all_properties = false);
        public Block GetBlock(string blockid, bool load_all_properties = false);
        public Block GetBlock(AnvilItem item, bool load_all_properties = false);
        public AnvilCategory GetCategory(string categoryid, bool load_all_properties = false);
        public AnvilCategory GetCategory(AnvilItem item, bool load_all_properties = false);
        public AnvilImage GetImage(string imageid, bool load_all_properties = false);
        public AnvilImage GetImage(AnvilItem item, bool load_all_properties = false);
        public Manuscript GetManuscript(string manuscriptid, bool load_all_properties = false);
        public Manuscript GetManuscript(AnvilItem item, bool load_all_properties = false);
        public ManuscriptVersion GetManuscriptVersion(string manuscriptid, bool load_all_properties = false);
        public ManuscriptVersion GetManuscriptVersion(AnvilItem item, bool load_all_properties = false);
        public ManuscriptVersionExport GetManuscriptVersionExport(string manuscriptid, bool load_all_properties = false);
        public ManuscriptVersionExport GetManuscriptVersionExport(AnvilItem item, bool load_all_properties = false);
        public AnvilUser GetCurrentAnvilUser();
        public AnvilUser GetAnvilUser(string userid, bool load_all_properties = false);
        public AnvilUser GetAnvilUser(AnvilItem item, bool load_all_properties = false);
        public UserManuscripts GetUserManuscripts(string userid, bool load_all_properties = false); 
        public UserManuscripts GetUserManuscripts(AnvilItem item, bool load_all_properties = false);
        public UserWorlds GetUserWorlds(string userid, bool load_all_properties = false); 
        public UserWorlds GetUserWorlds(AnvilItem item, bool load_all_properties = false);
        public World GetWorld(string worldid, bool load_all_properties = false);
        public World GetWorld(AnvilItem item, bool load_all_properties = false);
        public WorldArticles GetWorldArticles(string worldid, bool load_all_properties = false);
        public WorldArticles GetWorldArticles(AnvilItem item, bool load_all_properties = false); 
        public WorldArticles SearchWorldArticles(string worldid, AnvilSearchOptions options, bool load_all_properties = false);
        public WorldArticles SearchWorldArticles(AnvilItem item, AnvilSearchOptions options, bool load_all_properties = false);
        public WorldCategories GetWorldCategories(string worldid, bool load_all_properties = false);
        public WorldCategories GetWorldCategories(AnvilItem item, bool load_all_properties = false);
        public WorldCategories SearchWorldCategories(string worldid, AnvilSearchOptions options, bool load_all_properties = false);
        public WorldCategories SearchWorldCategories(AnvilItem item, AnvilSearchOptions options, bool load_all_properties = false);
        public WorldBlocks GetWorldBlocks(string idworldid, bool load_all_properties = false);
        public WorldBlocks GetWorldBlocks(AnvilItem item, bool load_all_properties = false);
        public WorldBlocks SearchWorldBlocks(string worldid, AnvilSearchOptions options, bool load_all_properties = false);
        public WorldBlocks SearchWorldBlocks(AnvilItem item, AnvilSearchOptions options, bool load_all_properties = false);
        public WorldImages GetWorldImages(string worldid, bool load_all_properties = false);
        public WorldImages GetWorldImages(AnvilItem item, bool load_all_properties = false);
        public WorldImages SearchWorldImages(string worldid, AnvilSearchOptions options, bool load_all_properties = false);
        public WorldImages SearchWorldImages(AnvilItem item, AnvilSearchOptions options, bool load_all_properties = false);

    }
}
