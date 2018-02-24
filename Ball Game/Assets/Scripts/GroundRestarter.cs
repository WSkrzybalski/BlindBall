using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRestarter : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(Application.loadedLevel);
    }

}
