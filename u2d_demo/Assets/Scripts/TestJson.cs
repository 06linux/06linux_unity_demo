using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestJson : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BtnRead()
    {
        string json = BaseUtil.UserDataLoad("zhangsan.json");
        if(json != "")
        {
            UserData userdata = JsonUtility.FromJson<UserData>(json);
            Debug.Log("BtnRead" + userdata.desc);
            Debug.Log(userdata);
        }
    }

    public void BtnWrite()
    {
        UserData userdata = new UserData();
        userdata.name = "张三";
        userdata.age = 11;
        userdata.desc = "我是张三asdfasdfasdf";
        userdata.friends = new List<string> { "王五", "赵六" };
        userdata.friends.Add("李四") ;
        userdata.friends.Add("大王") ;


        string json = JsonUtility.ToJson(userdata);
        Debug.Log("json="+json);

        BaseUtil.UserDataSave("zhangsan.json", json);
    }
}
