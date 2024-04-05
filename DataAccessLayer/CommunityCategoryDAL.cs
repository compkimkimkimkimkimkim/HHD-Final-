using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HHD.DataAccessLayer
{
    public class CommunityCategoryDAL
    {
        public static bool AddCommunityCategory(CommunityCategory communityCategory)
        {
            string sql = $"INSERT INTO [dbo].[CommunityCategory] (CommunityId, CategoryId) VALUES ({communityCategory.CommunityId}, {communityCategory.CategoryId})";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static CommunityCategory GetCommunityCategory(int id)
        {
            string sql = $"SELECT * FROM [dbo].[CommunityCategory] WHERE Id = {id}";
            DataTable dt = SqlHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return new CommunityCategory
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    CommunityId = Convert.ToInt32(dr["CommunityId"]),
                    CategoryId = Convert.ToInt32(dr["CategoryId"])
                };
            }
            return null;
        }

        public static bool DeleteCommunityCategory(int communityId)
        {
            string sql = $"DELETE FROM [dbo].[CommunityCategory] WHERE CommunityId = {communityId}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static bool UpdateCommunityCategory(CommunityCategory communityCategory)
        {
            string sql = $"UPDATE [dbo].[CommunityCategory] SET CommunityId = {communityCategory.CommunityId}, CategoryId = {communityCategory.CategoryId} WHERE Id = {communityCategory.Id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static List<CommunityCategory> GetCommunityCategoryList()
        {
            List<CommunityCategory> list = new List<CommunityCategory>();
            string sql = "SELECT * FROM [dbo].[CommunityCategory]";
            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new CommunityCategory
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    CommunityId = Convert.ToInt32(dr["CommunityId"]),
                    CategoryId = Convert.ToInt32(dr["CategoryId"])
                });
            }
            return list;
        }

        public static List<CommunityCategoryCustom> GetCommunityCategoryList(int communityId)
        {
            List<CommunityCategoryCustom> list = new List<CommunityCategoryCustom>();
            string sql = $"SELECT CC.*, C.Name FROM [dbo].[CommunityCategory] CC LEFT JOIN [dbo].[Category] C ON CC.CategoryId = C.Id " +
                $"WHERE CommunityId = {communityId}";
            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new CommunityCategoryCustom
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    CommunityId = Convert.ToInt32(dr["CommunityId"]),
                    CategoryId = Convert.ToInt32(dr["CategoryId"]),
                    CategoryName = Convert.ToString(dr["Name"])
                });
            }
            return list;
        }
    }
}