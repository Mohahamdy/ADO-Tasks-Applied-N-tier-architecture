using ITI.DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ITI.Business
{
    public static class InstructorCoursesService
    {
        public static DataTable GetCourses(int insId)
        {
            return DbContext.Select($"select C.Crs_Id,C.Crs_Name,C.Crs_Duration,T.Top_Name,T.Top_Id\r\nfrom Instructor I inner join Ins_Course IC\r\n\t\ton I.Ins_Id = IC.Ins_Id \r\n\tinner join Course C\r\n\t\ton C.Crs_Id = IC.Crs_Id\r\n\tinner join Topic T\r\n\t\ton T.Top_Id = C.Top_Id\r\nwhere I.Ins_Id = {insId}");
        }

        public static int InsertIntoCourse(Course crs)
        {
            return DbContext.ExecuteNonQuery($"insert into Course values('{crs.Name}',{crs.Duration},{crs.TopId})");
        }

        public static int InsertIntoIns_Crs(int insId,int crsId)
        {
            return DbContext.ExecuteNonQuery($"insert into Ins_Course values({insId},{crsId},'good')");
        }

        public static int UpdateCourse(Course crs)
        {
            return DbContext.ExecuteNonQuery($"update Course \r\nset Crs_Duration={crs.Duration}, Crs_Name='{crs.Name}', Top_Id={crs.TopId}\t\r\nwhere Crs_Id = {crs.Id}");
        }

        public static int DeleteIns_Crs(int crsId)
        {
            return DbContext.ExecuteNonQuery($"delete from Ins_Course where Crs_Id={crsId}");
        }

        public static int DeleteCourse(int crsId)
        {
            return DbContext.ExecuteNonQuery($"delete from Course where Crs_Id = {crsId}");
        }

        public static int GetCourseId(Course crs)
        {
            return (int)DbContext.ExecuteScalar($"select crs_id from Course where Crs_Name = '{crs.Name}' and Top_Id = {crs.TopId} and Crs_Duration = {crs.Duration}");
        }
    }
}
