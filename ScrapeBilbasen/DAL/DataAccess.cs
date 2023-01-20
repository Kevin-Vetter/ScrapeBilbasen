using HtmlAgilityPack;
using ScrapeBilbasen.Model;
using ScrapySharp.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using ScrapySharp.Network;
using System.Text;

namespace ScrapeBilbasen.DAL
{
    public class DataAccess
    {
        public static IConfiguration Configuration { get; private set; }
        static string connectionString;
        static ScrapingBrowser _scrapingBrowser = new ScrapingBrowser();
        public DataAccess()
        {
            var build = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = build.Build();
            connectionString = Configuration.GetConnectionString("DefaultConnection");
        }

        #region Car 
      
        #endregion
    }
}
