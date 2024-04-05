using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HHD.DataAccessLayer
{
	public class LocalTionDAL
	{

		public static bool AddLocaltion(LocalTion localtion)
		{
			string sql = $"INSERT INTO [dbo].[Localtion] (LocaltionName, LocaltionAddress, LocaltionType, LineColour, Distance, Minutes, BusNumbers) " +
				$"VALUES (N'{localtion.LocaltionName}', '{localtion.LocaltionAddress}', {localtion.LocaltionType}, '{localtion.LineColour}', {localtion.Distance}, {localtion.Minutes}, '{localtion.BusNumbers}')";
			return SqlHelper.ExcuteNonQuery(sql) > 0;
		}

		public static bool EditLocaltion(int id, LocalTion localtion)
		{
			string sql = $"Update Localtion set LocaltionName = N'{localtion.LocaltionName}',LocaltionAddress = '{localtion.LocaltionAddress}', LocaltionType={localtion.LocaltionType}, LineColour = '{localtion.LineColour}', Distance = {localtion.Distance}, Minutes = {localtion.Minutes}, BusNumbers = '{localtion.BusNumbers}' where id = {id}";
			return SqlHelper.ExcuteNonQuery(sql) > 0;
		}
       

        public static bool DeleteLocaltion(int id)
		{
			string sql = $"DELETE FROM [dbo].[Localtion] WHERE id = {id}";
			return SqlHelper.ExcuteNonQuery(sql) > 0;
		}
        public static bool UpdateLocaltion(int id, LocalTion localtion)
        {
            string sql = $"UPDATE [dbo].[Localtion] SET LocaltionName = N'{localtion.LocaltionName}', LocaltionAddress = '{localtion.LocaltionAddress}' WHERE id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
        public static bool UpdateLocaltionMrt(int id, LocalTion localtion)
        {
            string sql = $"UPDATE [dbo].[Localtion] SET LocaltionName = N'{localtion.LocaltionName}', LineColour = '{localtion.LineColour}', Distance = '{localtion.Distance}', Minutes = '{localtion.Minutes}' WHERE id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
        public static bool UpdateLocaltionbus(int id, LocalTion localtion)
        {
            string sql = $"UPDATE [dbo].[Localtion] SET LocaltionName = N'{localtion.LocaltionName}',  BusNumbers = '{localtion.BusNumbers}' WHERE id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
        public static List<LocalTion> GetAllByType(int type)
		{


			List<LocalTion> list = new List<LocalTion>();
			string sql = $"select * from  Localtion where LocaltionType = {type}";

			DataTable dt = SqlHelper.GetDataTable(sql);
			foreach (DataRow dr in dt.Rows)
			{
				list.Add(new LocalTion
				{
					Id = Convert.ToInt32(dr["id"]),
					LocaltionName = dr["LocaltionName"].ToString(),
					LocaltionAddress = dr["LocaltionAddress"].ToString(),
					LineColour = dr["LineColour"].ToString(),
					Distance = Convert.ToDecimal(dr["Distance"].ToString()),
					Minutes = Convert.ToInt32(dr["Minutes"].ToString()),
					BusNumbers = dr["BusNumbers"].ToString(),
					LocaltionType = Convert.ToInt32(dr["LocaltionType"]),
					Images = dr["Images"] + "",
				});
			}
			return list;

		}


		public static LocalTion GetById(int id)
		{
			string query = $"select * from Localtion where id = {id}";
			DataTable dt = SqlHelper.GetDataTable(query);
			List<LocalTion> list = new List<LocalTion>();
			foreach (DataRow dr in dt.Rows)
			{
				list.Add(new LocalTion
				{
					Id = Convert.ToInt32(dr["id"]),
					LocaltionName = dr["LocaltionName"].ToString(),
					LocaltionAddress = dr["LocaltionAddress"].ToString(),
					LineColour = dr["LineColour"].ToString(),
					Distance = Convert.ToInt32(dr["Distance"].ToString()),
					Minutes = Convert.ToInt32(dr["Minutes"].ToString()),
					BusNumbers = dr["BusNumbers"].ToString(),
					LocaltionType = Convert.ToInt32(dr["LocaltionType"]),
				});
			}
			return list.FirstOrDefault();
		}


	}
}