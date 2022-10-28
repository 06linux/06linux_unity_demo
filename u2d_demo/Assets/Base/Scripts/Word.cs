using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

// 一个汉字的显示，可以单独设置颜色，大小，字体样式等属性
public class Word : MonoBehaviour
{

    public char mWord = 'X';
    public Color mColor;
    public int mFontSize = 10;
    public FontStyles mFontStyle = FontStyles.Normal;
    public float mDelayTime = 0;            // 设置文字等待多长时间后显示


    // 当调用Start, 成员变量已经完成初始化
    void Start()
    {
        if(mDelayTime > 0)
        {
            setHidden();
            Invoke("setShowTween", mDelayTime);
        }
        else
        {
            setShow();
        }
    }

    public void setWord(char word)
    {
        mWord = word;
    }
    public void setColor(Color color)
    {
        mColor = color;
    }
    public void setColor(int fontSize)
    {
        mFontSize = fontSize;
    }

    public void setDelayTime(float delay)
    {
        mDelayTime = delay;
    }

    public void setFontSize(int fontSize)
    {
        mFontSize = fontSize;
    }

    public void setFontStyle(FontStyles style)
    {
        mFontStyle = style;
    }


    void setShow()
    {
        setTextPro(mWord, mColor, mFontSize, mFontStyle, 1);
    }

    void setShowTween()
    {
        setShow();
        transform.localScale = new Vector3(0.1f, 0.1f, 1);
        transform.DOScale(new Vector3(1, 1, 1), 0.35f);
    }

    void setHidden()
    {
        setTextPro(mWord, mColor, mFontSize, mFontStyle, 0);
    }


    // 设置文字的显示样式, alpha 控制显示
    void setTextPro(char word, Color color, int fontSize, FontStyles style, float alpha = 1)
    {
        TextMeshPro txtPro = GetComponent<TextMeshPro>();
        if (txtPro)
        {
            txtPro.SetText("" + word);
            txtPro.fontSize = fontSize;          // 文字大小
            txtPro.color = new Color(color.r, color.g, color.b, alpha);
            txtPro.fontStyle = style;  // 文字样式
        }
    }
}
