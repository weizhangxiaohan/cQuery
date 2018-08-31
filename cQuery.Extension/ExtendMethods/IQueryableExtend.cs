using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cQuery.Extension.ExtendMethods
{
    public static class IQueryableExtend
    {
        public static List<T> ToPagedList<T>(this IQueryable<T> query,int pageIndex,int pageSize)
        {
            return  query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }

        public static async Task<List<T>> ToPagedListAsync<T>(this IQueryable<T> query,int pageIndex,int pageSize)
        {
            return await query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }
    }
}
