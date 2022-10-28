using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TestTween : MonoBehaviour
{
    public GameObject npc;

    private Sequence sequence;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BtnMove()
    {
        npc.transform.position = new Vector3(0, 0, 0);
        npc.transform.DOMove(new Vector3(7, 3, 0), 2);
    }

    public void BtnScale()
    {
        DOTween.Sequence(npc.transform.DOScale(new Vector3(3, 3, 3), 2));
        DOTween.Sequence(npc.transform.DOScale(new Vector3(1, 1, 1), 2));
    }


    public void BtnRoate()
    {
        //npc.transform.DORotate(new Vector3(0, 0, 180), 2);
        //npc.transform.DOShakePosition(5);
        Sequence seq = DOTween.Sequence();
        seq.Append(npc.transform.DORotate(new Vector3(0, 0, 180), 1));
        seq.Append(npc.transform.DORotate(new Vector3(0, 0, 360), 1));

        seq.Append(npc.transform.DORotate(new Vector3(0, 0, 180), 1));
        seq.Append(npc.transform.DORotate(new Vector3(0, 0, 360), 1));
        seq.Append(npc.transform.DORotate(new Vector3(0, 0, 360), 1));
        seq.Append(npc.transform.DORotate(new Vector3(0, 0, 360), 1));
        seq.Append(npc.transform.DORotate(new Vector3(0, 0, 360), 1));
        seq.Append(npc.transform.DORotate(new Vector3(0, 0, 360), 1));

    }

    // 序列动画
    public void BtnSequence()
    {
        sequence = DOTween.Sequence();

        Tween tween1 = npc.transform.DOMove(new Vector3(7, 3, 0), 1);
        Tween tween2 = npc.transform.DOMove(new Vector3(7, -3, 0), 1);
        Tween tween3 = npc.transform.DOMove(new Vector3(-7, -3, 0), 1);
        Tween tween4 = npc.transform.DOMove(new Vector3(-7, 3, 0), 1);
        Tween tween5 = npc.transform.DOMove(new Vector3(0, 0, 0), 1);

        sequence.Append(tween1);
        sequence.AppendCallback(() => {
            Debug.Log("callBack 111....");
        });
        sequence.Append(tween2);
        sequence.AppendCallback(() => {
            Debug.Log("callBack 222....");
        });
        sequence.Append(tween3);
        sequence.AppendCallback(()=>{
            Debug.Log("callBack 333....");
        });
        sequence.Append(tween4);
        sequence.Append(tween5);
        sequence.Append(npc.transform.DOShakePosition(2));
        sequence.AppendCallback(callBack);


    }


    public void callBack()
    {
        Debug.Log("callBack ....");


    }
}
