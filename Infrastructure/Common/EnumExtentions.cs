﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HackerearthDesktop.Infrastructure.Common
{
    //public static class EnumExtensions
    //{
       
    //    private static readonly
    //        ConcurrentDictionary<string, string> DisplayNameCache = new ConcurrentDictionary<string, string>();

    //    public static string DisplayDescription(this Enum value)
    //    {
    //        var key = $"{value.GetType().FullName}.{value}";

    //        var displayName = DisplayNameCache.GetOrAdd(key, x =>
    //        {
    //            var name = (DescriptionAttribute[])value
    //                .GetType()
    //                .GetTypeInfo()
    //                .GetField(value.ToString())
    //                .GetCustomAttributes(typeof(DescriptionAttribute), false);

    //            return name.Length > 0 ? name[0].Description : value.ToString();
    //        });

    //        return displayName;
    //    }
    //}

}
