﻿using System;
using System.Linq;
using System.Reflection;
using NyaaWrapper.Attributes;

namespace NyaaWrapper.Extensions
{
    internal static class EnumExtensions
    {
        public static string GetName(this Enum source)
        {
            return source.GetType().GetMember(source.ToString()).FirstOrDefault()
                ?.GetCustomAttribute<NameAttribute>()?.Name;
        }
        
        public static string GetUri(this Enum source)
        {
            return source.GetType().GetMember(source.ToString()).FirstOrDefault()
                ?.GetCustomAttribute<UriAttribute>()?.Uri;
        }
    }
}