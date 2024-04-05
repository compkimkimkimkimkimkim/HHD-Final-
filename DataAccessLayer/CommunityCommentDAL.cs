using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HHD.DataAccessLayer
{
    public class CommunityCommentDAL
    {
        public static bool AddCommunityComment(CommunityComment communityComment)
        {
            string sql = $"INSERT INTO [dbo].[CommunityComment] (CommunityId, Username, Password, Content, CreationTime) VALUES ({communityComment.CommunityId}, '{communityComment.Username}', '{communityComment.Password}', '{communityComment.Content}', '{communityComment.CreationTime:yyyy-MM-dd HH:mm:ss}')";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static CommunityComment GetCommunityComment(int id)
        {
            string sql = $"SELECT * FROM [dbo].[CommunityComment] WHERE Id = {id}";
            DataTable dt = SqlHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return new CommunityComment
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    CommunityId = Convert.ToInt32(dr["CommunityId"]),
                    Username = dr["Username"].ToString(),
                    Password = dr["Password"].ToString(),
                    Content = dr["Content"].ToString(),
                    CreationTime = Convert.ToDateTime(dr["CreationTime"])
                };
            }
            return null;
        }

        public static bool DeleteCommunityComment(int communityId)
        {
            string sql = $"DELETE FROM [dbo].[CommunityComment] WHERE CommunityId = {communityId}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static bool Delete(int id)
        {
            string sql = $"DELETE FROM [dbo].[CommunityComment] WHERE Id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }


        public static bool UpdateCommunityComment(CommunityComment communityComment)
        {
            string sql = $"UPDATE [dbo].[CommunityComment] SET CommunityId = {communityComment.CommunityId}, Username = '{communityComment.Username}', Password = '{communityComment.Password}', Content = '{communityComment.Content}', CreationTime = '{communityComment.CreationTime:yyyy-MM-dd HH:mm:ss}' WHERE Id = {communityComment.Id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static List<CommunityComment> GetCommunityCommentList()
        {
            List<CommunityComment> list = new List<CommunityComment>();
            string sql = "SELECT * FROM [dbo].[CommunityComment]";
            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new CommunityComment
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    CommunityId = Convert.ToInt32(dr["CommunityId"]),
                    Username = dr["Username"].ToString(),
                    Password = dr["Password"].ToString(),
                    Content = dr["Content"].ToString(),
                    CreationTime = Convert.ToDateTime(dr["CreationTime"])
                });
            }
            return list;
        }

        public static List<CommunityComment> GetCommunityCommentList(int communityId)
        {
            List<CommunityComment> list = new List<CommunityComment>();
            string sql = $"SELECT * FROM [dbo].[CommunityComment] WHERE CommunityId = {communityId}";
            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new CommunityComment
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    CommunityId = Convert.ToInt32(dr["CommunityId"]),
                    Username = dr["Username"].ToString(),
                    Password = dr["Password"].ToString(),
                    Content = dr["Content"].ToString(),
                    CreationTime = Convert.ToDateTime(dr["CreationTime"])
                });
            }
            return list;
        }
    }
}