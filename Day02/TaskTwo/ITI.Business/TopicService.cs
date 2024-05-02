using ITI.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Business
{
    public static class TopicService
    {
        public static DataTable GetTopics()
        {
            return DbContext.Select("select Top_Id,Top_Name from Topic");
        }

    }
}
