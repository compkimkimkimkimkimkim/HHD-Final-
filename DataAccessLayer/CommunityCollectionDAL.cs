using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HHD.DataAccessLayer
{
    public class CommunityCollectionDAL
    {
        public static bool AddCommunityCollection(CommunityCollection communityCollection)
        {
            string sql = $"INSERT INTO [dbo].[CommunityCollection] (CommunityId, UserId) VALUES ({communityCollection.CommunityId}, {communityCollection.UserId})";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static CommunityCollection GetCommunityCollection(int id)
        {
            string sql = $"SELECT * FROM [dbo].[CommunityCollection] WHERE Id = {id}";
            DataTable dt = SqlHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return new CommunityCollection
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    CommunityId = Convert.ToInt32(dr["CommunityId"]),
                    UserId = Convert.ToInt32(dr["UserId"])
                };
            }
            return null;
        }

        public static bool DeleteCommunityCollection(int communityId)
        {
            string sql = $"DELETE FROM [dbo].[CommunityCollection] WHERE CommunityId = {communityId}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static bool Delete(int userId, int communityId)
        {
            string sql = $"DELETE FROM [dbo].[CommunityCollection] WHERE UserId = {userId} AND CommunityId = {communityId}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static bool UpdateCommunityCollection(CommunityCollection communityCollection)
        {
            string sql = $"UPDATE [dbo].[CommunityCollection] SET CommunityId = {communityCollection.CommunityId}, UserId = {communityCollection.UserId} WHERE Id = {communityCollection.Id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static List<CommunityCollection> GetCommunityCollectionList()
        {
            List<CommunityCollection> list = new List<CommunityCollection>();
            string sql = "SELECT * FROM [dbo].[CommunityCollection]";
            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new CommunityCollection
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    CommunityId = Convert.ToInt32(dr["CommunityId"]),
                    UserId = Convert.ToInt32(dr["UserId"])
                });
            }
            return list;
        }

        public static List<CommunityCollection> GetCommunityCollectionList(int communityId)
        {
            List<CommunityCollection> list = new List<CommunityCollection>();
            string sql = $"SELECT * FROM [dbo].[CommunityCollection] WHERE CommunityId = {communityId}";
            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new CommunityCollection
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    CommunityId = Convert.ToInt32(dr["CommunityId"]),
                    UserId = Convert.ToInt32(dr["UserId"])
                });
            }
            return list;
        }

        public static int GetCount(int communityId)
        {
            string sql = $"SELECT COUNT(*) AS Total FROM [dbo].[CommunityCollection] WHERE CommunityId = {communityId}";
            DataTable dt = SqlHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return Convert.ToInt32(dr["Total"]);
            }
            return 0;
        }
    }
}