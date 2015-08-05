using System;

namespace AngularWebAPIPagination.Helpers
{
    public class PageCount
    {
        public static int Count(int totalRecord, int pageSize)
        {
            
            return Convert.ToInt16(Math.Ceiling( (double)totalRecord / pageSize));
        }
    }
}