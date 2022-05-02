using System;
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
        Type type = myObj.GetType();
        TypeInfo typeInfo = type.GetTypeInfo();
        IEnumerable<PropertyInfo> pList = typeInfo.GetProperties();
        IEnumerable<MethodInfo> mList = typeInfo.GetMethods();
        System.Console.WriteLine("{0} Properties:", typeInfo.Name);
        foreach (PropertyInfo element in pList)
        {
            System.Console.WriteLine(element.Name);
        }
        
        System.Console.WriteLine("{0} Methods:", typeInfo.Name);
        foreach (MethodInfo element in mList)
        {
            System.Console.WriteLine(element.Name);
        }
    }
}
