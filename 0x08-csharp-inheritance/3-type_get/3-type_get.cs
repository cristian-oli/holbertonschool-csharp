﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

/// <sumary> Statement for Obj class </sumary>
class Obj
{
    /// <sumary>
    /// Method that prints the names of the available properties and methods of an object
    /// <param name="myObj"> Object </param>
    /// </sumary>
    public static void Print(object myObj)
    {
        TypeInfo type = myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> pList = type.DeclaredProperties;
        IEnumerable<MethodInfo> mList = type.DeclaredMethods;
        Console.WriteLine("{0} Properties:", type.Name);
        foreach (PropertyInfo element in pList)
        {
            Console.WriteLine(element.Name);
        }
        Console.WriteLine("{0} Methods:", type.Name);
        foreach (MethodInfo element in mList)
        {
            Console.WriteLine(element.Name);
        }
    }
}
