using System;
using System.Reflection;

namespace CRMCore.Entities
{
    public static class NameGetter
    {
        public static string GetName(this Type type)
        {
            return (type.GetCustomAttribute(typeof(NameAttribute), false) as NameAttribute).Name;
        }

        public static string GetName(this PropertyInfo info)
        {
            return (info.GetCustomAttribute(typeof(NameAttribute), false) as NameAttribute).Name;
        }
    }
}
