using System;
using System.Collections.Generic;

/// <sumary> Statement for Obj class </sumary>
class Obj
{

    /// <sumary>
    /// method that returns True if the object is an instance of,
    /// or if the object is an instance of a class that inherited from, Array,
    /// otherwise return False.
    /// <param name="obj"> Object to verify </param>
    /// </sumary>
    public static bool IsInstanceOfArray(object obj)
    {
        return (obj.GetType().IsArray) ? true : false ;
    }
}
