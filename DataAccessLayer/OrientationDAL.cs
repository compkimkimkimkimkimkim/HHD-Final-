using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HHD.DataAccessLayer
{
	public class OrientationDAL
	{
		public static bool AddOrientation(Orientation uo)
		{
			string sql = $"INSERT INTO [dbo].[Orientation] (Images, Name,Rank,Description,Content,Title,OrientationType) " +
				$"VALUES ('{uo.Images}', '{uo.Name}',{uo.Rank},N'{uo.Description}',N'{uo.Content}', N'{uo.Title}', {uo.OrientationType})";
			return SqlHelper.ExcuteNonQuery(sql) > 0;
		}

		public static bool EditOrientation(int id, Orientation e)
		{
			string sql = $"Update Orientation set Images = N'{e.Images}',Name = N'{e.Name}', Content = N'{e.Content}',Rank={e.Rank}, Description = N'{e.Description}', OrientationType = {e.OrientationType}  where id = {id}";
			return SqlHelper.ExcuteNonQuery(sql) > 0;
		}
        public static bool UpdateOrientation(int id, Orientation orientation)
        {
            string sql = $"UPDATE [dbo].[Orientation] SET Images = N'{orientation.Images}', Content = '{orientation.Content}',  Title = '{orientation.Title}' WHERE id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
        public static bool DeleteOrientation(int id)
		{
			string sql = $"DELETE FROM Orientation where id = {id}";
			return SqlHelper.ExcuteNonQuery(sql) > 0;
		}

		public static List<Orientation> GetAllByType(int type)
		{


			List<Orientation> list = new List<Orientation>();
			string sql = $"select * from Orientation where OrientationType = {type}";

			DataTable dt = SqlHelper.GetDataTable(sql);
			foreach (DataRow dr in dt.Rows)
			{
				list.Add(new Orientation
				{
					id = Convert.ToInt32(dr["id"]),
					Images = dr["Images"].ToString(),
					Content = dr["Content"].ToString(),
					Description = dr["Description"].ToString(),
					Title = dr["Title"].ToString(),
					Name = dr["Name"].ToString(),
					Rank = Convert.ToInt32(dr["Rank"].ToString()),
					OrientationType = Convert.ToInt32(dr["OrientationType"].ToString()),
				});
			}
			return list;

		}
		public static Orientation GetById(int id)
		{
			string query = $"select * from Orientation where id = {id}";
			DataTable dt = SqlHelper.GetDataTable(query);
			List<Orientation> list = new List<Orientation>();
			foreach (DataRow dr in dt.Rows)
			{
				list.Add(new Orientation
				{
					id = Convert.ToInt32(dr["id"]),
					Images = dr["Images"].ToString(),
					Content = dr["Content"].ToString(),
					Title = dr["Title"].ToString(),
					Description = dr["Description"].ToString(),
					Name = dr["Name"].ToString(),
					Rank = Convert.ToInt32(dr["Rank"].ToString()),
					OrientationType = Convert.ToInt32(dr["OrientationType"].ToString()),
				});
			}
			return list.FirstOrDefault();
		}

	}
}