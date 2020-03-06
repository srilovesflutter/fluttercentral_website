using Flutterweb.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Flutterweb.Models
{
    public class Article
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        //[AllowHtml]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
        public string Category { get; set; }
        public string Tags { get; set; }
        public string Author { get; set; }
        public DateTime Submited { get; set; }
        public DateTime Edited { get; set; }
        public bool Draft { get; set; } = true;
        public string Widget { get; set; }

        [NotMapped]
        public SelectList CategoryList { get; set; }

        [NotMapped]
        public ArticlePager Pagerarticle { get; set; }

        public class SQLDbConnection : DbContext
        {
            public DbSet<Article> Articles { get; set; }
        }

        public DataSet GetArticlesData(int? pageIndex)
        {
            string query = "[GetArticlesonScroll]";
            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PageIndex", pageIndex);
            cmd.Parameters.AddWithValue("@PageSize", 4);
            cmd.Parameters.Add("@PageCount", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            return GetData(cmd);
        }

        public DataSet GetJobsData(int? pageIndex)
        {
            string query = "[GetJobssonScroll]";
            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PageIndex", pageIndex);
            cmd.Parameters.AddWithValue("@PageSize", 4);
            cmd.Parameters.Add("@PageCount", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            return GetData(cmd);
        }


        public DataSet GetAnswersData(int? pageIndex)
        {
            string query = "[GetAnswersonScroll]";
            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PageIndex", pageIndex);
            cmd.Parameters.AddWithValue("@PageSize", 4);
            cmd.Parameters.Add("@PageCount", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            return GetData(cmd);
        }

        public DataSet GetRecentArticlesData(int pageIndex)
        {
            string query = "[GetRecentArticlesonScroll]";
            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PageIndex", pageIndex);
            cmd.Parameters.AddWithValue("@PageSize", 4);
            cmd.Parameters.Add("@PageCount", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            return GetData(cmd);
        }

        private static DataSet GetData(SqlCommand cmd)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: false);
            var configuration = builder.Build();
            string strConnString = configuration.GetConnectionString("DefaultConnection");

            using (SqlConnection con = new SqlConnection(strConnString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataSet ds = new DataSet())
                    {
                        sda.Fill(ds, "Titles");
                        DataTable dt = new DataTable("PageCount");
                        dt.Columns.Add("PageCount");
                        dt.Rows.Add();
                        dt.Rows[0][0] = cmd.Parameters["@PageCount"].Value;
                        ds.Tables.Add(dt);
                        return ds;
                    }
                }
            }
        }

        public DataSet GetSearchData(string searchstring, int? pageIndex, bool fullsearch)
        {
            string query = "[GetResultsonSearch]";
            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SearchString", searchstring);
            cmd.Parameters.AddWithValue("@PageIndex", pageIndex);
            cmd.Parameters.AddWithValue("@PageSize", 4);
            cmd.Parameters.AddWithValue("@fullsearch", fullsearch);
            cmd.Parameters.Add("@PageCount", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            return GetData(cmd);
        }


    }

    public class ArticleCategory
    {
        public IEnumerable<SelectListItem> GetArticleCategory()
        {
            yield return new SelectListItem { Text = "News", Value = "News" };
            yield return new SelectListItem { Text = "Article", Value = "Article" };
            yield return new SelectListItem { Text = "Errors", Value = "Errors" };
            yield return new SelectListItem { Text = "Tutorials", Value = "Tutorials" };
            yield return new SelectListItem { Text = "Question", Value = "Question" };
            yield return new SelectListItem { Text = "Jobs", Value = "Jobs" };
        }
    }


    public class ArticlePager
    {
        public ArticlePager(int cid)
        {
            PreviousHeader = null;
            NextHeader = null;
            nextId = 0;
            previousId = 0;

            try
            {
                var nextaid = db.Articles.Where(i => i.ID > cid & !i.Draft).OrderBy(z => z.ID).FirstOrDefault();
                nextId = nextaid.ID;
                Article articleNext = db.Articles.Find(nextId);

                NextHeader = !String.IsNullOrWhiteSpace(articleNext.Title) && articleNext.Title.Length >= 30 ? articleNext.Title.Substring(0, 30) + ".." : articleNext.Title;
            }
            catch
            {

            }
            try
            {
                var previousaidList = db.Articles.Where(i => i.ID < cid & !i.Draft).ToList();
                previousaidList.Reverse();
                var previousaid = previousaidList.OrderBy(z => z.ID).LastOrDefault();
                previousId = previousaid.ID;

                Article articlePrevious = db.Articles.Find(previousId);

                PreviousHeader = !String.IsNullOrWhiteSpace(articlePrevious.Title) && articlePrevious.Title.Length >= 30 ? articlePrevious.Title.Substring(0, 30) + ".." : articlePrevious.Title;
            }
            catch
            {

            }
        }

        private ApplicationDbContext db;

        public string PreviousHeader { get; set; }
        public string NextHeader { get; set; }
        public int previousId { get; set; }
        public int nextId { get; set; }
        public int currentID { get; set; }

    }

}