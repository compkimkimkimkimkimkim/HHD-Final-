using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HHD.DataAccessLayer
{
    public class PSBCDAL
    {
        public static bool AddPSBC(PSBC uo)
        {
            string sql = $"INSERT INTO [dbo].[PSBC] (Images, Name,Content,Title,PSBCType) " +
                $"VALUES ('{uo.Images}', N'{uo.Name}',N'{uo.Content}',N'{uo.Title}', {uo.PSBCType})";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static bool EditPSBC(int id, PSBC e)
        {
            string sql = $"Update PSBC set Images = N'{e.Images}',Name = N'{e.Name}', Content = N'{e.Content}' where id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static bool DeletePSBC(int id)
        {
            string sql = $"DELETE FROM [dbo].[PSBC] WHERE id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static List<PSBC> GetAllByType(int type)
        {
            List<PSBC> list = new List<PSBC>();
            string sql = $"select * from  PSBC where PSBCType = {type}";

            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new PSBC
                {
                    id = Convert.ToInt32(dr["id"]),
                    Images = dr["Images"].ToString(),
                    Content = dr["Content"].ToString(),
                    Title = dr["Title"].ToString(),
                    Name = dr["Name"].ToString(),
                    PSBCType = Convert.ToInt32(dr["PSBCType"].ToString()),
                });
            }
            return list;

        }
        public static PSBC GetById(int id)
        {
            string query = $"select * from PSBC where id = {id}";
            DataTable dt = SqlHelper.GetDataTable(query);
            List<PSBC> list = new List<PSBC>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new PSBC
                {
                    id = Convert.ToInt32(dr["id"]),
                    Images = dr["Images"].ToString(),
                    Content = dr["Content"].ToString(),
                    Title = dr["Title"].ToString(),
                    Name = dr["Name"].ToString(),
                    PSBCType = Convert.ToInt32(dr["PSBCType"].ToString()),
                });
            }
            return list.FirstOrDefault();
        }

    }
}