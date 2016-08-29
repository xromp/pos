using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
namespace POS.Helpers
{
    public static class LinqHelper
    {
        public static IEnumerable<T> OrEmptyIfNull<T>(this IEnumerable<T> source)
        {
            return source ?? Enumerable.Empty<T>();
        }
        public static T? GetValue<T>(this DataRow _dr, string _col) where T : struct
        {
            if (_dr == null) return null;
            return _dr.IsNull(_col) ? null : _dr[_col] as T?;
        }
        public static string GetText(this DataRow _dr, string _col)
        {
            if (_dr == null) return string.Empty;
            return _dr.IsNull(_col) ? string.Empty : _dr[_col] as string ?? string.Empty;
        }
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> source)
        {
            return source ?? Enumerable.Empty<T>();
        }
    }
}
