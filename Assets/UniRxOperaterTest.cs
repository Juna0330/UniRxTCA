using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class UniRxOperaterTest : MonoBehaviour
{
    [SerializeField] private Text everyUpdateText;
    [SerializeField] private int valu=0;
    // Start is called before the first frame update
    void Start()
    {
        ///3秒後に呼び出してくれる
        var timer=Observable.Timer(System.TimeSpan.FromSeconds(2));
        timer.Subscribe(onNext_=>Debug.Log("Hello Timer!")); 
        //3秒後にプリント
        ///マイフレーム呼び出してくれる
        var every=Observable.EveryUpdate();
        every.Subscribe(onNext_=>{ 
            valu+=1;
            everyUpdateText.text=valu.ToString();
            });
        ///５秒ごとに呼び出してくれる
   Observable.Timer(System.TimeSpan.FromSeconds(5),System.TimeSpan.FromSeconds(1))
            .Subscribe(_=>Debug.Log("５秒後以降に1秒ごと呼び出されます"))
            .AddTo(gameObject); //GameObjectがDestoryされたタイミングで処理を停止します
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
