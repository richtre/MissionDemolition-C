using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodySleep : MonoBehaviour
{
    private int sleepCountdown = 4;
    private Rigidbody rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {
        
    }
    void Start()
    {
        if (sleepCountdown > 0)
        {
            rigid.Sleep();
            sleepCountdown--;
        }    
    }

}
