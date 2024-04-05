using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
namespace HHD.DataAccessLayer
{
    public class CommunityDAL
    {
        public static int AddCommunity(Community community)
        {
            string sql = $"INSERT INTO [dbo].[Community] (Name, Password, Title, CategoryId, Content, CreationTime) VALUES ('{community.Name}', '{community.Password}', '{community.Title}', {community.CategoryId}, '{community.Content}', '{community.CreationTime:yyyy-MM-dd HH:mm:ss}');" +
                $"select @@identity";
            var obj = SqlHelper.ExecuteScalar(sql);

            if (obj == null)
            {
                return -1;
            }

            return Convert.ToInt32(obj.ToString());
        }


        public static bool DeleteCommunity(int id)
        {
            string sql = $"DELETE FROM [dbo].[Community] WHERE Id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }


        public static bool UpdateCommunity(Community community)
        {
            string sql = $"UPDATE [dbo].[Community] SET Name = '{community.Name}', Password = '{community.Password}', Title = '{community.Title}', CategoryId = {community.CategoryId}, Content = '{community.Content}', CreationTime = '{community.CreationTime:yyyy-MM-dd HH:mm:ss}' WHERE Id = {community.Id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
        public static bool UpdateCommunity2(Community community, int id)
        {
            string sql = $"UPDATE [dbo].[Community] SET Title = '{community.Title}', Content = '{community.Content}' WHERE Id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static Community GetCommunity(int id)
        {
            string sql = $"SELECT * FROM [dbo].[Community] WHERE Id = {id}";
            DataTable dt = SqlHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return new Community
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Name = dr["Name"].ToString(),
                    Password = dr["Password"].ToString(),
                    Title = dr["Title"].ToString(),
                    CategoryId = Convert.ToInt32(dr["CategoryId"]),
                    Content = dr["Content"].ToString(),
                    CreationTime = Convert.ToDateTime(dr["CreationTime"])
                };
            }
            return null;
        }

        public static Community GetById(int id)
        {
            string query = $"SELECT * FROM [dbo].[Community] WHERE Id = {id}";
            DataTable dt = SqlHelper.GetDataTable(query);
            List<Community> list = new List<Community>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Community
                {
                    Id = Convert.ToInt32(dr["id"]),
                    Name = dr["Name"].ToString(),
                    Password = dr["Password"].ToString(),
                    Title = dr["Title"].ToString(),
                    CategoryId = Convert.ToInt32(dr["CategoryId"].ToString()),
                    Content = dr["Content"].ToString(),
                });
            }
            return list.FirstOrDefault();
        }
        public static List<Community> GetCommunityList()
        {
            List<Community> list = new List<Community>();
            string sql = "SELECT * FROM [dbo].[Community] ORDER BY CreationTime DESC";
            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Community
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Name = dr["Name"].ToString(),
                    Password = dr["Password"].ToString(),
                    Title = dr["Title"].ToString(),
                    CategoryId = Convert.ToInt32(dr["CategoryId"]),
                    Content = dr["Content"].ToString(),
                    CreationTime = Convert.ToDateTime(dr["CreationTime"])
                });
            }
            return list;
        }

        public static List<Community> GetCommunityList(int pageSize, int pageNum)
        {
            List<Community> list = new List<Community>();
            string sql = "SELECT * FROM [dbo].[Community] ORDER BY CreationTime DESC" +
                $" OFFSET ({pageNum} - 1) * {pageSize} ROWS" +
                $" FETCH NEXT {pageSize} ROWS ONLY";
            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Community
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Name = dr["Name"].ToString(),
                    Password = dr["Password"].ToString(),
                    Title = dr["Title"].ToString(),
                    CategoryId = Convert.ToInt32(dr["CategoryId"]),
                    Content = dr["Content"].ToString(),
                    CreationTime = Convert.ToDateTime(dr["CreationTime"])
                });
            }
            return list;
        }

        public static List<Community> GetCommunityList(int categoryId)
        {
            List<Community> list = new List<Community>();
            string sql = $"SELECT * FROM [dbo].[Community] C INNER JOIN CommunityCategory CC ON CC.CommunityId = C.Id " +
                $" WHERE CC.CategoryId = {categoryId} ORDER BY CreationTime DESC";
            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Community
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Name = dr["Name"].ToString(),
                    Password = dr["Password"].ToString(),
                    Title = dr["Title"].ToString(),
                    CategoryId = Convert.ToInt32(dr["CategoryId"]),
                    Content = dr["Content"].ToString(),
                    CreationTime = Convert.ToDateTime(dr["CreationTime"])
                });
            }
            return list;
        }

        public static List<Community> GetCommunityList(int categoryId, int pageSize, int pageNum)
        {
            List<Community> list = new List<Community>();
            string sql = $"SELECT * FROM [dbo].[Community] C INNER JOIN CommunityCategory CC ON CC.CommunityId = C.Id " +
                $" WHERE CC.CategoryId = {categoryId} ORDER BY CreationTime DESC" +
                $" OFFSET ({pageNum} - 1) * {pageSize} ROWS" +
                $" FETCH NEXT {pageSize} ROWS ONLY";
            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Community
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Name = dr["Name"].ToString(),
                    Password = dr["Password"].ToString(),
                    Title = dr["Title"].ToString(),
                    CategoryId = Convert.ToInt32(dr["CategoryId"]),
                    Content = dr["Content"].ToString(),
                    CreationTime = Convert.ToDateTime(dr["CreationTime"])
                });
            }
            return list;
        }
    }
}