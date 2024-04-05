using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.BusinessLogicLayer
{
	public class PSBCBLL
	{
		public static bool AddPSBC(PSBC st)
		{
			return PSBCDAL.AddPSBC(st);
		}
		public static bool EditPSBC(PSBC st, int id)
		{
			return PSBCDAL.EditPSBC(id, st);
		}
		public static bool DeletePSBC(int id)
		{
			return PSBCDAL.DeletePSBC(id);
		}
		public static List<PSBC> GetByType(int type)
		{
			return PSBCDAL.GetAllByType(type);
		}
		public static PSBC GetByIdDTO(int id)
		{
			return PSBCDAL.GetById(id);
		}
	}
}