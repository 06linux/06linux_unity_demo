using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestScene : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BtnExit()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void BtnMusic1Open()
    {
        Transform child = transform.Find("music1");
        if (child)
        {
            child.gameObject.SendMessage("Play");
        }
    }

    public void BtnMusic1Close()
    {
        Transform child = transform.Find("music1");
        if (child)
        {
            child.gameObject.SendMessage("Pause");
        }
    }

    public void BtnMusic2Open()
    {
        Transform child = transform.Find("music2");
        if (child)
        {
            child.gameObject.SendMessage("Play");
        }
    }

    public void BtnMusic2Close()
    {
        Transform child = transform.Find("music2");
        if (child)
        {
            child.gameObject.SendMessage("Pause");
        }
    }

    public void BtnSound1()
    {
        Transform musicForm = transform.Find("sound1");
        if (musicForm)
        {
            musicForm.gameObject.SendMessage("Play");
        }
    }

    public void BtnSound2()
    {
        Transform musicForm = transform.Find("sound2");
        if (musicForm)
        {
            musicForm.gameObject.SendMessage("Play");
        }

        Debug.Log("BtnSound2");
    }

    // 遍历当前对象下的 child 对象
    public void TestPrintChild()
    {
        Debug.Log("TestPrintChild:" + gameObject.name);

        // 遍历当前对象的子对象
        foreach (Transform child in transform)
        {
            Debug.Log("name:" + child.gameObject.name + "--" + child.name);
            child.gameObject.SendMessage("play");
        }
    }

}
