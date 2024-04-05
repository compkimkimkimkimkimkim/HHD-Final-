using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.BusinessLogicLayer
{
	public class CommunityCategoryBLL
	{
		public static List<CommunityCategoryCustom> GetCommunityCategoryList(int communityId)
		{
			return CommunityCategoryDAL.GetCommunityCategoryList(communityId);
		}

		public static bool AddCommunityCategory(CommunityCategory communityCategory)
		{
			return CommunityCategoryDAL.AddCommunityCategory(communityCategory);
		}

		public static bool DeleteCommunityCategory(int communityId)
		{
			return CommunityCategoryDAL.DeleteCommunityCategory(communityId);
		}
	}
}