using System;

class Character
{
    public static bool IsLower(char c)
    {
        String alphabeth = "abcdefghijklmnopqrstuvwxyz";
        int i = 0;

        for (; i < alphabeth.Length; i++)
        {
            if (c == alphabeth[i])
                return true;
        }
        return false;
    }
}
