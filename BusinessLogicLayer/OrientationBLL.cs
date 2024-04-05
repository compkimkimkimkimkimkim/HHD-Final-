using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.BusinessLogicLayer
{
	public class OrientationBLL
	{
		public static bool AddOrientation(Orientation st)
		{
			return OrientationDAL.AddOrientation(st);
		}
		public static bool EditOrientation(Orientation st, int id)
		{
			return OrientationDAL.EditOrientation(id, st);
		}
		public static bool DeleteOrientation(int id)
		{
			return OrientationDAL.DeleteOrientation(id);
		}
		public static List<Orientation> GetByType(int type)
		{
			return OrientationDAL.GetAllByType(type);
		}
		public static Orientation GetByIdDTO(int id)
		{
			return OrientationDAL.GetById(id);
		}
	}
}