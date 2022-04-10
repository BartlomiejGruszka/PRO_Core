﻿using System;
using System.Collections;
using System.Collections.Generic;

public static class IsNullOrEmptyExtension
{
    public static bool IsNullOrEmpty(this IEnumerable source)
    {
        if (source != null)
        {
            foreach (object obj in source)
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
    {
        if (source != null)
        {
            foreach (T obj in source)
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsNullOrEmpty(this int[] array)
    {
        return (array == null || array.Length == 0);
    }
    public static bool IsNullOrEmpty(this string[] array)
    {
        return (array == null || array.Length == 0);
    }
}