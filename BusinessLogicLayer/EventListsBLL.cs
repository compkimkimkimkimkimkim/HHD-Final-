

using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.BusinessLogicLayer
{
	public class EventListsBLL
	{
		public static bool AddEvent(EventLists e)
		{
			return EventListDAL.AddEvent(e);
		}
		public static bool EditEvent(EventLists e, int id)
		{
			return EventListDAL.EditEvent(id, e);
		}
		public static bool DeleteEvent(int id)
		{
			return EventListDAL.DeleteEvent(id);
		}
		public static List<EventLists> GetByType(int type)
		{
			return EventListDAL.GetAllByType(type);
		}
		public static EventLists GetByIdDTO(int id)
		{
			return EventListDAL.GetById(id);
		}
	}
}