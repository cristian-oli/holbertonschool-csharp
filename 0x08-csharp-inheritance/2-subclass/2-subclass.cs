using System;

/// <sumary> Statement fot Obj class </sumary>
class Obj
{
    /// <sumary>
    /// returns True if the object is an instance of a class that inherits
    /// from the specified class, otherwise return False
    /// <param name="derivedType"> First class </param>
    /// <param name="baseType"> Second class </param>
    /// </sumary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType == baseType) ? false : (derivedType.IsSubclassOf(baseType)) ? true : false;
    }  
}
