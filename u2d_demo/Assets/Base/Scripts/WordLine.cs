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
        foreach (char word in mWords)
        {
            GameObject obj = Instantiate(mWordPrefeb, transform);
            Word objWord = obj.GetComponent<Word>();     // 获取挂载的脚本组件对象
            obj.name = "" + word;
            objWord.setWord(word, mColor, mFontSize, mFontStyle);
        }
    }

    // 只能在初始化的时候调用一次
    public void setLine(string words)
    {
        mWords = words;
    }

    public void setLine(string words, Color color, int fontSize, FontStyles style)
    {
        mWords = words;
        mColor = color;
        mFontSize = fontSize;
        mFontStyle = style;
    }

}
