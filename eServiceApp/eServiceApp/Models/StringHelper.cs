using System;
using System.Collections.Generic;
using System.Text;

namespace eServiceApp.Models
{
    public static class StringHelper
    {
        public static TResult NullSafe<TObj, TResult>(this TObj obj, Func<TObj, TResult> func, TResult ifNullReturn = default(TResult))
        {
            return obj != null ? func(obj) : ifNullReturn;
        }
    }
}
