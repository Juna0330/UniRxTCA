using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class AsyncSubjectSampleB : MonoBehaviour
{
    [SerializeField] private AsyncSubjectSampleA sampleA;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SampleBの初期化が実行されました");
        sampleA.OninitializedAsync.Subscribe(x => Initialize());
    }
    void Initialize() {
        Debug.Log("SampleBの初期化が終わりました");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
