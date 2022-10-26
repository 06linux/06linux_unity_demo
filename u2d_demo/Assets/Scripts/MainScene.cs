using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void BtnStart()
    {
        Debug.Log("ClickBtnStart Click, 开始按钮");
        SceneManager.LoadScene("GameScene");
    }

    public void BtnTest()
    {
        Debug.Log("BtnTest Click, 测试按钮");
        SceneManager.LoadScene("TestScene");


    }
}
