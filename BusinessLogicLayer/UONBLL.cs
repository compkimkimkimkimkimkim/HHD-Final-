using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.BusinessLogicLayer
{
	public class UONBLL
	{
		public static bool AddUoN(UoN st)
		{
			return UONDAL.AddUON(st);
		}
		public static bool EditUOn(UoN st, int id)
		{
			return UONDAL.EditUON(id, st);
		}
		public static bool DeleteUON(int id)
		{
			return UONDAL.DeleteUON(id);
		}
		public static List<UoN> GetByType(int type)
		{
			return UONDAL.GetAllByType(type);
		}
		public static UoN GetByIdDTO(int id)
		{
			return UONDAL.GetById(id);
		}
	}
}