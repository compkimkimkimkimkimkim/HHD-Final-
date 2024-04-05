using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.BusinessLogicLayer
{
	public class CategoryBLL
	{
		public static List<Category> GetList()
		{
			return CategoryDAL.GetList();
		}
	}
}