using HHD.Models;
using HHD.UserInterfaceLayer.Site;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace HHD.DataAccessLayer
{
	public class MarianSquareDAL
	{
       
        public static bool AddMarianSquare(MarianSquare marianSquare)
		{
			string sql = $"INSERT INTO [dbo].[LevelMary] (name, filePath, type) VALUES (N'{marianSquare.name}', '{marianSquare.filePath}', {marianSquare.type})";
			return SqlHelper.ExcuteNonQuery(sql) > 0;
		}

		public static bool EditMarianSquare(int id, MarianSquare marianSquare)
		{
			string sql = $"Update LevelMary set name = N'{marianSquare.name}',filePath = '{marianSquare.filePath}', type={marianSquare.type} where Id = {id}";
			return SqlHelper.ExcuteNonQuery(sql) > 0;
		}
        public static bool UpdateMarianSquare(int id, MarianSquare marianSquare)
        {
            string sql = $"UPDATE [dbo].[LevelMary] SET filePath = N'{marianSquare.filePath}', name = '{marianSquare.name}' WHERE Id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
        public static bool DeleteMarianSquare(int id)
		{
			string sql = $"DELETE FROM [dbo].[LevelMary] WHERE Id = {id}";
			return SqlHelper.ExcuteNonQuery(sql) > 0;
		}

		public static List<MarianSquare> GetAllByType(int type)
		{


			List<MarianSquare> list = new List<MarianSquare>();
			string sql = $"select * from  LevelMary where type = {type}";

			DataTable dt = SqlHelper.GetDataTable(sql);
			foreach (DataRow dr in dt.Rows)
			{
				list.Add(new MarianSquare
				{
					Id = Convert.ToInt32(dr["Id"]),
					filePath =dr["filePath"].ToString(),
					name = dr["name"].ToString(),
					type =Convert.ToInt32(dr["type"]),
				});
			}
			return list;

		}
		public static MarianSquare GetById(int id)
		{
			string query = $"select * from LevelMary where Id = {id}";
			DataTable dt = SqlHelper.GetDataTable(query);
			List<MarianSquare> list = new List<MarianSquare>();
			foreach (DataRow dr in dt.Rows)
			{
				list.Add(new MarianSquare
				{
					Id = Convert.ToInt32(dr["Id"]),
					filePath = dr["filePath"].ToString(),
					name = dr["name"].ToString(),
					type = Convert.ToInt32(dr["type"]),
				});
			}
			return list.FirstOrDefault();
		}


	}
}