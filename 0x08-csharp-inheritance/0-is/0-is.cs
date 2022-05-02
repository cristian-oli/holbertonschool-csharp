using System;

/// <sumary> Statement for Obj class </sumary>
class Obj
{
    /// <sumary>
    /// Method that returns True if the object is an int, otherwise return False
    /// <param name="obj"> Object to verify </param>
    /// </sumary>
    public static bool IsOfTypeInt(object obj)
    {
        return (obj.GetType() == typeof(int)) ? true : false;
    }
}
