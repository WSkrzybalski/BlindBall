using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightController : MonoBehaviour {

    public Light lt;
    void Start()
    {
        lt = GetComponent<Light>();
    }
    void Update()
    {

       
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Finish")
        {
            lt.color = Color.green;
        }
    }
}
