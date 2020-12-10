using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3
{
    public static class SessionExtensions
    {
        public static string ConvertTime(this DateTime dataTime, ISession session)
        {
            var time = session.GetInt32("timezone");
            if (time != null)
            {
                var timeOffSet = int.Parse(time.ToString());
                dataTime = dataTime.AddMinutes(-1 * timeOffSet);
                return dataTime.ToString();
            }
            return dataTime.ToLocalTime().ToString();
        }
    }
}
