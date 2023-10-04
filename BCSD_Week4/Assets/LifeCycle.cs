using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    
    void Start()
    {
        
    }


    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical") * Time.deltaTime, 0);
        transform.Translate(vec);
    }
}
