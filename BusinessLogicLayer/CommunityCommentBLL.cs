using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.BusinessLogicLayer
{
	public class CommunityCommentBLL
	{
		public static List<CommunityComment> GetCommunityCommentList(int communityId)
		{
			return CommunityCommentDAL.GetCommunityCommentList(communityId);
		}

		public static bool CheckPassword(int id, string password)
		{
			CommunityComment communityComment = CommunityCommentDAL.GetCommunityComment(id);

			if (communityComment != null && communityComment.Password == password)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool AddCommunityComment(CommunityComment communityComment)
		{
			return CommunityCommentDAL.AddCommunityComment(communityComment);
		}

		public static bool Delete(int id)
		{
			return CommunityCommentDAL.Delete(id);
		}
	}
}