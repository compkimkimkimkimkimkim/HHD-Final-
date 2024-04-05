using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.BusinessLogicLayer
{
	public class CommunityPictureBLL
	{
		public static bool AddCommunityPicture(CommunityPicture communityPicture)
		{
			return CommunityPictureDAL.AddCommunityPicture(communityPicture);
		}

		public static List<CommunityPicture> GetCommunityPictureList(int communityId)
		{
			return CommunityPictureDAL.GetCommunityPictureList(communityId);
		}

		public static bool UpdateCommunityPicture(CommunityPicture communityPicture)
		{
			return CommunityPictureDAL.UpdateCommunityPicture(communityPicture);
		}
        public static CommunityPicture GetByIdDTO(int id)
        {
            return CommunityPictureDAL.GetCommunityPicture(id);
        }
    }
}