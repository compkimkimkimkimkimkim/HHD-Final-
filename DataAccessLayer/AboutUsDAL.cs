using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HHD.DataAccessLayer
{
	public class AboutUsDAL
	{
		public static bool AddAboutUs(AboutUs uo)
		{
			string sql = $"INSERT INTO [dbo].[AboutUs] (Images,Name,Major,Ambitions,AboutUsType) " +
				$"VALUES ('{uo.Images}', N'{uo.Name}',N'{uo.Major}',N'{uo.Ambitions}', {uo.AboutUsType})";
			return SqlHelper.ExcuteNonQuery(sql) > 0;
		}
        public static bool AddAboutUs2(AboutUs uo)
        {
            string sql = $"INSERT INTO [dbo].[AboutUs] (Images,Name) " +
                $"VALUES ('{uo.Images}', N'{uo.Name}')";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static bool EditAboutUs(int id, AboutUs e)
		{
			string sql = $"Update AboutUs set Images = '{e.Images}',Name = N'{e.Name}', Major = N'{e.Major}',Ambitions=N'{e.Ambitions}', AboutUsType = {e.AboutUsType}  where id = {id}";
			return SqlHelper.ExcuteNonQuery(sql) > 0;
		}
        public static bool UpdateAboutUs(int id, AboutUs about)
        {
            string sql = $"UPDATE [dbo].[AboutUs] SET Images = N'{about.Images}', Name = '{about.Name}', Major = N'{about.Major}', Ambitions = '{about.Ambitions}' WHERE id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
        public static bool UpdateAboutUsTool(int id, AboutUs about)
        {
            string sql = $"UPDATE [dbo].[AboutUs] SET Images = N'{about.Images}', Name = '{about.Name}' WHERE id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
        public static bool DeleteAboutUs(int id)
		{
			string sql = $"DELETE FROM AboutUs where id = {id}";
			return SqlHelper.ExcuteNonQuery(sql) > 0;
		}

		public static List<AboutUs> GetAllByType(int type)
		{


			List<AboutUs> list = new List<AboutUs>();
			string sql = $"select * from  AboutUs where AboutUsType = {type}";

			DataTable dt = SqlHelper.GetDataTable(sql);
			foreach (DataRow dr in dt.Rows)
			{
				list.Add(new AboutUs
				{
					id = Convert.ToInt32(dr["id"]),
					Images = dr["Images"].ToString(),
					Name = dr["Name"].ToString(),
					Major = dr["Major"].ToString(),
					Ambitions = dr["Ambitions"].ToString(),
					AboutUsType = Convert.ToInt32(dr["AboutUsType"].ToString()),
					
				});
			}
			return list;

		}
		public static AboutUs GetById(int id)
		{
			string query = $"select * from AboutUs where id = {id}";
			DataTable dt = SqlHelper.GetDataTable(query);
			List<AboutUs> list = new List<AboutUs>();
			foreach (DataRow dr in dt.Rows)
			{
				list.Add(new AboutUs
				{
					id = Convert.ToInt32(dr["id"]),
					Images = dr["Images"].ToString(),
					Name = dr["Name"].ToString(),
					Major = dr["Major"].ToString(),
					Ambitions = dr["Ambitions"].ToString(),
					AboutUsType = Convert.ToInt32(dr["AboutUsType"].ToString()),
				});
			}
			return list.FirstOrDefault();
		}

	}
}