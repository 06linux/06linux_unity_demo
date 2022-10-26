using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// 多行文字显示
public class WordMultLine : MonoBehaviour
{
    public GameObject mWordLinePrefeb;

    public string mWords;
    public Color mColor;
    public int mFontSize = 10;
    public FontStyles mFontStyle = FontStyles.Normal;

    // Start is called before the first frame update
    void Start()
    {
        string[] lines = mWords.Split(' ');
        for (int i = 0; i < lines.Length; i++)
        {
            //Debug.Log("line=" + lines[i]);
            initLine(lines[i], i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setWords(string words)
    {
        mWords = words;
    }

    public void setWords(string words, Color color, int fontSize, FontStyles style)
    {
        mWords = words;
        mFontStyle = style;
        mColor = color;
        mFontSize = fontSize;
    }


    // 初始化一行文字显示
    void initLine(string line, int index)
    {
        GameObject obj = Instantiate(mWordLinePrefeb, transform);
        WordLine objScript = obj.GetComponent<WordLine>();     // 获取挂载的脚本组件对象
        obj.name = "line_" + index;
        objScript.setLine(line, mColor, mFontSize, mFontStyle);
    }
   
}
