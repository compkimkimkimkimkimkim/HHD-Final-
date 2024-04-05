using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HHD.Models;
namespace HHD.DataAccessLayer
{
	public class Level3DAL
	{
		public static bool AddLevel3MarinSquare()
		{
			string sql = $"INSERT INTO [dbo].[LevelMary] (CommunityId, Path) VALUES ({communityPicture.CommunityId}, '{communityPicture.Path}')";
			return SqlHelper.ExcuteNonQuery(sql) > 0;
		}
	}
}