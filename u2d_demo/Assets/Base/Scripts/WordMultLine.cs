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

    public float mStartTime = 0;        // 初始显示时间
    public float mDelayTimeWord = 0;    // 下一个文字的时间间隔
    public float mDelayTimeLine = 0;    // 每行的时间间隔


    // Start is called before the first frame update
    void Start()
    {
        float startTime = mStartTime;

        string[] lines = mWords.Split(' ');
        for (int i = 0; i < lines.Length; i++)
        {
            //Debug.Log("line=" + lines[i]);
            initLine(lines[i], i, startTime, mDelayTimeWord);
            startTime += (lines[i].Length * mDelayTimeWord + mDelayTimeLine);

            //initLine(lines[i], i, mDelayTime*i, 0);
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
    void initLine(string line, int index, float startTime, float deleyTime)
    {
        GameObject obj = Instantiate(mWordLinePrefeb, transform);
        WordLine objScript = obj.GetComponent<WordLine>();     // 获取挂载的脚本组件对象
        obj.name = "line_" + index;
        objScript.setWords(line, mColor, mFontSize, mFontStyle, startTime, deleyTime);
    }
   
}
