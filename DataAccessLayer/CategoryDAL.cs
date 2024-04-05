using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HHD.DataAccessLayer
{
    public class CategoryDAL
    {
        public static Category Get(int id)
        {
            string sql = $"SELECT Id, Name FROM [dbo].[Category] WHERE Id = {id}";
            DataTable dt = SqlHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                return new Category
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    Name = dt.Rows[0]["Name"].ToString()
                };
            }
            return null;
        }

        public static List<Category> GetList()
        {
            List<Category> list = new List<Category>();
            string sql = "SELECT Id, Name FROM [dbo].[Category]"; 
            DataTable dt = SqlHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new Category
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = dr["Name"].ToString()
                    });
                }
            }
            return list;
        }

        public static bool AddCategory(Category category)
        {
            string sql = $"INSERT INTO [dbo].[Category] (Name) VALUES ({category.Name})";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static bool DeleteCategory(int id)
        {
            string sql = $"DELETE FROM [dbo].[Category] WHERE Id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static bool UpdateCategory(Category category)
        {
            string sql = $"UPDATE [dbo].[Category] SET Name = {category.Name} WHERE Id = {category.Id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
    }
}