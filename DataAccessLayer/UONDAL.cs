using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;

namespace HHD.DataAccessLayer
{
    public class UONDAL
    {
        public static bool AddUON(UoN uo)
        {
            string sql = $"INSERT INTO [dbo].[UoN] (Images, Name,Rank,Description,Content,Title,UoNType) " +
                $"VALUES ('{uo.Images}', '{uo.Name}',{uo.Rank},N'{uo.Description}',N'{uo.Content}', N'{uo.Title}', N'{uo.UoNType}')";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static bool EditUON(int id, UoN e)
        {
            string sql = $"Update UoN set Images = N'{e.Images}',Name = N'{e.Name}',Rank= N'{e.Rank}', Description = N'{e.Description}' where id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static bool DeleteUON(int id)
        {
            string sql = $"DELETE FROM UoN where id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static List<UoN> GetAllByType(int type)
        {


            List<UoN> list = new List<UoN>();
            string sql = $"select * from  UoN where UoNType = {type}";

            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new UoN
                {
                    id = Convert.ToInt32(dr["id"]),
                    Images = dr["Images"].ToString(),
                    Content = dr["Content"].ToString(),
                    Description = dr["Description"].ToString(),
                    Name = dr["Name"].ToString(),
                    Title = dr["Title"].ToString(),
                    Rank = Convert.ToInt32(dr["Rank"].ToString()),
                    UoNType = Convert.ToInt32(dr["UoNType"].ToString()),
                });
            }
            return list;

        }
        public static UoN GetById(int id)
        {
            string query = $"select * from UoN where id = {id}";
            DataTable dt = SqlHelper.GetDataTable(query);
            List<UoN> list = new List<UoN>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new UoN
                {
                    id = Convert.ToInt32(dr["id"]),
                    Images = dr["Images"].ToString(),
                    Content = dr["Content"].ToString(),
                    Description = dr["Description"].ToString(),
                    Name = dr["Name"].ToString(),
                    Title = dr["Title"].ToString(),
                    Rank = Convert.ToInt32(dr["Rank"].ToString()),
                    UoNType = Convert.ToInt32(dr["UoNType"].ToString()),
                });
            }
            return list.FirstOrDefault();
        }
    }
}