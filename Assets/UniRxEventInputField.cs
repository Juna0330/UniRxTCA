using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UniRx;

public class UniRxEventInputField : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var inputfield = GetComponent<InputField>();
        inputfield.OnValueChangedAsObservable().Subscribe(i => Debug.Log(i));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
