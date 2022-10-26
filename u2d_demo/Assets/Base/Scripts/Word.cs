using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// 一个汉字的显示，可以单独设置颜色，大小，字体样式等属性
public class Word : MonoBehaviour
{

    public char mWord = 'X';
    public Color mColor;
    public int mFontSize = 10;
    public FontStyles mFontStyle = FontStyles.Normal;


    void Awake()
    {
        setTextPro(mWord, mColor, mFontSize, mFontStyle);
    }


    public void setWord(char word)
    {
        mWord = word;
        setTextPro(mWord, mColor, mFontSize, mFontStyle);
    }

    public void setWord(char word, Color color, int fontSize, FontStyles style)
    {
        mWord = word;
        mFontStyle = style;
        mColor = color;
        mFontSize = fontSize;
        setTextPro(mWord, mColor, mFontSize, mFontStyle);
    }



    // 设置文字的显示样式
    void setTextPro(char word, Color color, int fontSize, FontStyles style)
    {
        TextMeshPro txtPro = GetComponent<TextMeshPro>();
        if (txtPro)
        {
            txtPro.SetText("" + word);
            txtPro.fontSize = fontSize;          // 文字大小
            txtPro.color = new Color(color.r, color.g, color.b);
            txtPro.fontStyle = style;  // 文字样式
        }
    }
}
