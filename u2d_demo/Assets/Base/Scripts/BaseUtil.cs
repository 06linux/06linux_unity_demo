using UnityEngine;
using System.IO;
using System;

public class BaseUtil
{
    // 保存用户存档
    public static void UserDataSave(string name, string data)
    {
        try
        {
            string path = Application.persistentDataPath + "/" + name;
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);
            writer.Write(data);
            writer.Close();
            fs.Close();

            Debug.Log("Success, UserDataSave path=" + path);
        }
        catch (Exception e)
        {
            Debug.LogError(e);
        }
    }

    // 读取用户存档
    public static string UserDataLoad(string name)
    {
        string retStr = "";

        try
        {
            string path = Application.persistentDataPath + "/" + name;
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader reader = new StreamReader(fs);
            retStr = reader.ReadToEnd();
            reader.Close();
            fs.Close();
        }
        catch(Exception e)
        {
            Debug.LogError(e);
        }

        return retStr;
    }

    // 读取资源文件，游戏配置数据，json 配置等等， 在 asset/ 目录下
    // 只读属性
    public static string ResDataLoad(string name)
    {
        string retStr = "";

        try
        {
            string path = Application.dataPath + "/" + name;
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader reader = new StreamReader(fs);
            retStr = reader.ReadToEnd();
            reader.Close();
            fs.Close();
        }
        catch (Exception e)
        {
            Debug.LogError(e);
        }

        return retStr;
    }
}
