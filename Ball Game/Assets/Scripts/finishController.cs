using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishController : MonoBehaviour {
    public bool finishTrigger = false;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("true");
        finishTrigger = true;
    }
}
