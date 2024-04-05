using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.BusinessLogicLayer
{
	public class StudentClubBLL
	{

		public static bool AddStudentClub(StudentClub st)
		{
			return StudentDAL.AddStudentClub(st);
		}
		public static bool EditStudentClub(StudentClub st, int id)
		{
			return StudentDAL.EditStudentClub(id,st);
		}
		public static bool DeleteStudentClub(int id)
		{
			return StudentDAL.DeleteStudentClub(id);
		}
		public static List<StudentClub> GetByType(int type)
		{
			return StudentDAL.GetAllByType(type);
		}
		public static StudentClub GetByIdDTO(int id)
		{
			return StudentDAL.GetById(id);
		}
	}
}