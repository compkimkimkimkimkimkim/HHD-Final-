using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Web;

namespace HHD.BusinessLogicLayer
{
    public class HomeBLL
    {
        public static bool AddHome(Home home)
        {
            return HomeDAL.AddHome(home);
        }
        public static bool EditHome(Home home, int id)
        {
            return HomeDAL.UpdateHome(id, home);
        }
        public static bool DeleteHome(int id)
        {
            return HomeDAL.DeleteHome(id);
        }
        public static List<Home> GetByType(int type)
        {
            return HomeDAL.GetAllByType(type);
        }
        public static Home GetByIdDTO(int id)
        {
            return HomeDAL.GetById(id);
        }
        public static Home UpdateLocaltion(int id)
        {
            return HomeDAL.GetById(id);
        }
    }
}
