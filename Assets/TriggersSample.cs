using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class TriggersSample : MonoBehaviour
{

    // Start is called before the first frame update
   private void Start()
    {
        var IsForceEnabled = true;
        var rigidBody = GetComponent<Rigidbody>();

        //フラグが有効な間、上向きに力を加える
        this.FixedUpdateAsObservable()
            .Where(_ => IsForceEnabled)
            .Subscribe(_ => rigidBody.AddForce(Vector3.up));

        //WarpZoneに侵入したらフラグを有効にする
        this.OnTriggerEnterAsObservable()
            .Where(x => x.gameObject.tag == "WarpZone")
            .Subscribe(_ => IsForceEnabled = true);
        //WarpZoneから出たらフラグを無効にする
        this.OnTriggerExitAsObservable()
            .Where(x => x.gameObject.tag == "WrapZone")
            .Subscribe(_ => IsForceEnabled = false);
        
       
    }


}
