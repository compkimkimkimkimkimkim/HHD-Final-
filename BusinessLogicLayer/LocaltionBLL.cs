using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.BusinessLogicLayer
{
	public class LocaltionBLL
	{
		public static bool AddLocaltion(LocalTion localtion)
		{
			return LocalTionDAL.AddLocaltion(localtion);
		}
		public static bool EditLocaltion(LocalTion localtion, int id)
		{
			return LocalTionDAL.EditLocaltion(id, localtion);
		}
		public static bool DeleteLocaltion(int id)
		{
			return LocalTionDAL.DeleteLocaltion(id);
		}
		public static List<LocalTion> GetByType(int type)
		{
			return LocalTionDAL.GetAllByType(type);
		}
		public static LocalTion GetByIdDTO(int id)
		{
			return LocalTionDAL.GetById(id);
		}
        public static LocalTion UpdateLocaltion(int id)
        {
            return LocalTionDAL.GetById(id);
        }
    }
}