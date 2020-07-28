﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspStore.Common
{
    public static class Pagination
    {
        public static IEnumerable<TSource> ToPaged<TSource>(
            this IEnumerable<TSource> source, 
            int page,
            int pageSize,
            out int rowsCount
            )
        {
            rowsCount = source.Count();
            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }
    }
}
