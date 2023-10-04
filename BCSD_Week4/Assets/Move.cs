using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(5, 2, -7);
    Vector3 velo = Vector3.zero;
    void FixedUpdate()
    {
        //1.MoveTowards
        //transform.position = Vector3.MoveTowards(transform.position, target, 2f);

        //2.SmoothDamp
        //transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        //3.Lerp(���� ����)
        //transform.position = Vector3.Lerp(transform.position, target, 0.1f);

        //4.Slerp(���� ���� ����)
        transform.position = Vector3.Slerp(transform.position, target, 0.05f);

    }
}
