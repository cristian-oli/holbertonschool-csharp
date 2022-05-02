using System;

/// <sumery> Statement for Shape class </sumery>
class Shape
{
    /// <sumery>
    /// Throws an NotImplementedException with the message Area() is not implemented
    /// </sumery>
    public virtual int Area()
    {
        throw new NotImplementedException ("Area() is not implemented");
    }
}
