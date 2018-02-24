using UnityEngine;
using System.Collections;
public class RotationController : MonoBehaviour
{
    public float speed = 1.0f;
    void Update()
    {
       
        transform.Rotate(new Vector3(0,0,30) * Time.deltaTime * speed);

       
    }
}