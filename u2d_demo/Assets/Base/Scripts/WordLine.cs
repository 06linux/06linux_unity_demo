using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// 一行文字
// 预制体设置说明
//
// WordLineV 垂直文字显示，
//          react transform  属性 width = 0，height = 0
//          grid layout group 属性 cellSize.x 必须为 0
//
// WordLineH 水平文字显示，
//          react transform  属性 height = 0，
//          grid layout group 属性 cellSize.y 必须为 0
//
// react width, height 同时设置为0， 可以固定 行或者列的显示为 1 就可以
//
public class WordLine : MonoBehaviour
{
    public GameObject mWordPrefeb;

    public string mWords;
    public Color mColor;
    public int mFontSize = 10;
    public FontStyles mFontStyle = FontStyles.Normal;

    public float mStartTime = 0;    // 初始显示时间
    public float mDelayTimeWord = 0;    // 下一个文字的时间间隔

    // Start is called before the first frame update
    void Start()
    {
        initWords(mWords);
    }


    // Update is called once per frame
    void Update()
    {

    }

    // 只能在初始化的时候调用一次
    void initWords(string words)
    {
        int index = 0;

        foreach (char word in mWords)
        {
            index++;

            GameObject obj = Instantiate(mWordPrefeb, transform);
            Word objScript = obj.GetComponent<Word>();     // 获取挂载的脚本组件对象
            objScript.name = "" + word;
            objScript.setWord(word);
            objScript.setColor(mColor);
            objScript.setFontSize(mFontSize);
            objScript.setFontStyle(mFontStyle);
            objScript.setDelayTime(mStartTime + index * mDelayTimeWord);
        }
    }

    // 只能在初始化的时候调用一次
    public void setWords(string words)
    {
        mWords = words;
    }

    public void setWords(string words, Color color, int fontSize, FontStyles style, float startTime, float deleyTimeWord)
    {
        mWords = words;
        mColor = color;
        mFontSize = fontSize;
        mFontStyle = style;
        mStartTime = startTime;
        mDelayTimeWord = deleyTimeWord;
    }

}
