using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.BusinessLogicLayer
{
	public class CommunityCollectionBLL
	{
		public static bool AddCommunityCollection(CommunityCollection communityCollection)
		{
			return CommunityCollectionDAL.AddCommunityCollection(communityCollection);
		}

		public static bool Delete(int userId, int communityId)
		{
			return CommunityCollectionDAL.Delete(userId, communityId);
		}
	}
}