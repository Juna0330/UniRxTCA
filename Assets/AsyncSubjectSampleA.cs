using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class AsyncSubjectSampleA : MonoBehaviour
{
    AsyncSubject<Unit> initializeAsyncSubject = new AsyncSubject<Unit>();
    public IObservable<Unit> OninitializedAsync {
        get { return initializeAsyncSubject; }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SampleAの初期化が実行されました");

        Debug.Log("SampleAの初期化が終わりました");

        initializeAsyncSubject.OnNext(Unit.Default);
        Debug.Log("通知しました");

        initializeAsyncSubject.OnNext(Unit.Default);
        Debug.Log("=======通知ました======");
        initializeAsyncSubject.OnCompleted();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
