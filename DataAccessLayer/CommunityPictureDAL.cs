using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HHD.DataAccessLayer
{
    public class CommunityPictureDAL
    {
        public static bool AddCommunityPicture(CommunityPicture communityPicture)
        {
            string sql = $"INSERT INTO [dbo].[CommunityPicture] (CommunityId, Path) VALUES ({communityPicture.CommunityId}, '{communityPicture.Path}')";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static CommunityPicture GetCommunityPicture(int id)
        {
            string sql = $"SELECT * FROM [dbo].[CommunityPicture] WHERE Id = {id}";
            DataTable dt = SqlHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return new CommunityPicture
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    CommunityId = Convert.ToInt32(dr["CommunityId"]),
                    Path = dr["Path"].ToString()
                };
            }
            return null;
        }

        public static bool DeleteCommunityPicture(int communityId)
        {
            string sql = $"DELETE FROM [dbo].[CommunityPicture] WHERE CommunityId = {communityId}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static bool UpdateCommunityPicture(CommunityPicture communityPicture)
        {
            string sql = $"UPDATE [dbo].[CommunityPicture] SET CommunityId = {communityPicture.CommunityId}, Path = '{communityPicture.Path}' WHERE Id = {communityPicture.Id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
        public static bool UpdateCommunityPicture2(int id, CommunityPicture communityPicture)
        {
            string sql = $"UPDATE [dbo].[CommunityPicture] SET  Path = '{communityPicture.Path}' WHERE Id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
        public static List<CommunityPicture> GetCommunityPictureList()
        {
            List<CommunityPicture> list = new List<CommunityPicture>();
            string sql = "SELECT * FROM [dbo].[CommunityPicture]";
            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new CommunityPicture
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    CommunityId = Convert.ToInt32(dr["CommunityId"]),
                    Path = dr["Path"].ToString()
                });
            }
            return list;
        }

        public static List<CommunityPicture> GetCommunityPictureList(int communityId)
        {
            List<CommunityPicture> list = new List<CommunityPicture>();
            string sql = $"SELECT * FROM [dbo].[CommunityPicture] WHERE CommunityId = {communityId}";
            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new CommunityPicture
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    CommunityId = Convert.ToInt32(dr["CommunityId"]),
                    Path = dr["Path"].ToString()
                });
            }
            return list;
        }
    }
}