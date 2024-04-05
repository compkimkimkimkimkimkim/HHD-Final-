using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.BusinessLogicLayer
{
	public class AboutUsBLL
	{
		public static bool AddAbout(AboutUs st)
		{
			return AboutUsDAL.AddAboutUs(st);
		}
		public static bool EditPSBC(AboutUs st, int id)
		{
			return AboutUsDAL.EditAboutUs(id, st);
		}
		public static bool DeletePSBC(int id)
		{
			return AboutUsDAL.DeleteAboutUs(id);
		}
		public static List<AboutUs> GetByType(int type)
		{
			return AboutUsDAL.GetAllByType(type);
		}
		public static AboutUs GetByIdDTO(int id)
		{
			return AboutUsDAL.GetById(id);
		}
	}
}