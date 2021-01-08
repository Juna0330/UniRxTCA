using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TestReactiveProperty : MonoBehaviour
{
    [SerializeField]
    private IntReactiveProperty playerHealth=new IntReactiveProperty(100);
    // Start is called before the first frame update
    void Start()
    {
        playerHealth.Subscribe(x=>Debug.Log(x));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
