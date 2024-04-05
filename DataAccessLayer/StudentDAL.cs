using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HHD.DataAccessLayer
{
    public class StudentDAL
    {
        public static bool AddStudentClub(StudentClub st)
        {
            string sql = $"INSERT INTO [dbo].[StudentClub] (Images, Name,Content,Link,StudentClubType) " +
                $"VALUES ('{st.Images}', N'{st.Name}',N'{st.Content}',N'{st.Link}', {st.StudentClubType})";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static bool EditStudentClub(int id, StudentClub e)
        {
            string sql = $"Update StudentClub set Images = N'{e.Images}',Name = N'{e.Name}',Content = N'{e.Content}',Link = N'{e.Link}'  where id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static bool DeleteStudentClub(int id)
        {
            string sql = $"DELETE FROM StudentClub where id = {id}";
            return SqlHelper.ExcuteNonQuery(sql) > 0;
        }

        public static List<StudentClub> GetAllByType(int type)
        {


            List<StudentClub> list = new List<StudentClub>();
            string sql = $"select * from  StudentClub where StudentClubType = {type}";

            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new StudentClub
                {
                    id = Convert.ToInt32(dr["id"]),
                    Images = dr["Images"].ToString(),
                    Name = dr["name"].ToString(),
                    Content = dr["Content"].ToString(),
                    Link = dr["Link"].ToString(),
                    StudentClubType = Convert.ToInt32(dr["StudentClubType"].ToString()),
                });
            }
            return list;

        }
        public static StudentClub GetById(int id)
        {
            string query = $"select * from StudentClub where id = {id}";
            DataTable dt = SqlHelper.GetDataTable(query);
            List<StudentClub> list = new List<StudentClub>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new StudentClub
                {
                    id = Convert.ToInt32(dr["id"]),
                    Images = dr["Images"].ToString(),
                    Name = dr["name"].ToString(),
                    Content = dr["Content"].ToString(),
                    Link = dr["Link"].ToString(),
                    StudentClubType = Convert.ToInt32(dr["StudentClubType"].ToString()),
                });
            }
            return list.FirstOrDefault();
        }
    }
}