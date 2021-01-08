using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;

public class UniRxEventSlider : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        var slider = GetComponent<Slider>();
        slider.OnValueChangedAsObservable().Subscribe(s => Debug.Log("Power;" + s));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
