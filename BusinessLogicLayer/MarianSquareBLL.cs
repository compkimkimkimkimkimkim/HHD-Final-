using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace HHD.BusinessLogicLayer
{
	public class MarianSquareBLL
	{
		public static bool AddMartianSquare(MarianSquare marianSquare)
		{
			return MarianSquareDAL.AddMarianSquare(marianSquare);
		}
		public static bool EditMarianSquare(MarianSquare marianSquare, int id)
		{
			return MarianSquareDAL.EditMarianSquare(id,marianSquare);
		}
		public static bool DeleteMarianSquare(int id)
		{
			return MarianSquareDAL.DeleteMarianSquare(id);
		}
		public static List<MarianSquare> GetByType(int type)
		{
			return MarianSquareDAL.GetAllByType(type);
		}
		public static MarianSquare GetByIdDTO(int id)
		{
			return MarianSquareDAL.GetById(id);
		}
	}
}