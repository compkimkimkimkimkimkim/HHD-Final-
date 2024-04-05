using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
namespace HHD.DataAccessLayer
{
    public class HomeDAL
    {
        public static bool AddHome(Home home)
        {
            string sql = $"INSERT INTO [dbo].[Home] (Image, Name, Description, category,Link,Content,Rank) " +
                $"VALUES (N'{home.Image}', '{home.Name}', '{home.Description}', '{home.category}','{home.Link}', '{home.Content}', '{home.Rank}')";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
        public static bool DeleteHome(int id)
        {
            string sql = $"DELETE FROM [dbo].[Home] WHERE IdHome = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
        public static bool UpdateHome(int id, Home home)
        {
            string sql = $"UPDATE [dbo].[Home] SET Image = N'{home.Image}' WHERE IdHome = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
        public static bool UpdateHome2(int id, Home home)
        {
            string sql = $"UPDATE [dbo].[Home] SET Image = N'{home.Image}',Name = N'{home.Name}',Link = N'{home.Link}',Content = N'{home.Content}' WHERE IdHome = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
        public static bool UpdateHome3(int id, Home home)
        {
            string sql = $"UPDATE [dbo].[Home] SET Description = N'{home.Description}',Rank = N'{home.Rank}' WHERE IdHome = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
        public static List<Home> GetAllByType(int type)
        {


            List<Home> list = new List<Home>();
            string sql = $"SELECT * FROM  Home WHERE category = {type}";

            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Home
                {
                    IdHome = Convert.ToInt32(dr["IdHome"]),
                    Image = dr["Image"].ToString(),
                    Name = dr["Name"].ToString(),
                    Description = dr["Description"].ToString(),
                    category = Convert.ToInt32(dr["category"]),
                    Link = dr["Link"].ToString(),
                    Content = dr["Content"].ToString(),
                    Rank = Convert.ToInt32(dr["Rank"]),

                });
            }
            return list;

        }


        public static Home GetById(int id)
        {
            string query = $"SELECT * FROM  Home WHERE IdHome = {id}";
            DataTable dt = SqlHelper.GetDataTable(query);
            List<Home> list = new List<Home>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Home
                {
                    IdHome = Convert.ToInt32(dr["IdHome"]),
                    Image = dr["Image"].ToString(),
                    Name = dr["Name"].ToString(),
                    Description = dr["Description"].ToString(),
                    category = Convert.ToInt32(dr["category"]),
                    Link = dr["Link"].ToString(),
                    Content = dr["Content"].ToString(),
                    Rank = Convert.ToInt32(dr["Rank"]),
                });
            }
            return list.FirstOrDefault();
        }
        public static bool UpdateHome4(int id, Home home)
        {
            string sql = $"UPDATE [dbo].[Home] SET Link = N'{home.Link}' WHERE IdHome = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
    }
}
