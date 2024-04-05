using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HHD.DataAccessLayer
{
    public class EventListDAL
    {
        public static bool AddEvent(EventLists e)
        {
            string sql = $"INSERT INTO [dbo].[EventLists] (EventPoster, EventType) " +
                $"VALUES ('{e.EventPoster}', {e.EventType})";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static bool EditEvent(int id, EventLists e)
        {
            string sql = $"Update EventLists set EventPoster = N'{e.EventPoster}' where id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }
        public static bool DeleteEvent(int id)
        {
            string sql = $"DELETE FROM [dbo].[EventLists]  WHERE id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static List<EventLists> GetAllByType(int type)
        {


            List<EventLists> list = new List<EventLists>();
            string sql = $"select * from  EventLists where EventType = {type}";

            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new EventLists
                {
                    Id = Convert.ToInt32(dr["id"]),
                    EventPoster = dr["EventPoster"].ToString(),
                    EventType = Convert.ToInt32(dr["EventType"].ToString()),
                });
            }
            return list;

        }


        public static EventLists GetById(int id)
        {
            string query = $"select * from EventLists where id = {id}";
            DataTable dt = SqlHelper.GetDataTable(query);
            List<EventLists> list = new List<EventLists>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new EventLists
                {
                    Id = Convert.ToInt32(dr["id"]),
                    EventPoster = dr["EventPoster"].ToString(),
                    EventType = Convert.ToInt32(dr["EventType"].ToString()),
                });
            }
            return list.FirstOrDefault();
        }
    }
}