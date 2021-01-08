using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using System;

public class UniRxEventButton : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        var button = GetComponent<Button>();
        button.OnClickAsObservable().Subscribe(x => Debug.Log("On Click Button"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
