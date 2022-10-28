using System;
using System.Collections.Generic;

[Serializable]
public class UserData
{
    public UserData()
    {
    }

    public string name;
    public int age;
    public string desc;

    public List<string> friends;
}
