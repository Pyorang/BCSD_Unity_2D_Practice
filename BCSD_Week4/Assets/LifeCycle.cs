using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    /*
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        
        if (Input.anyKey)
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");
        
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("�������� �����Ͽ����ϴ�.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("�������� �̵� ��");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("���������� �̵��� ���߾����ϴ�.");

        if (Input.GetMouseButtonDown(0))
            Debug.Log("�̻��� �߻�!");

        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� ������ ��...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�!!");

        if (Input.GetButtonDown("Fire1"))
            Debug.Log("����!");

        if (Input.GetButton("Fire1"))
            Debug.Log("���� ������ ��...");

        if (Input.GetButtonUp("Fire1"))
            Debug.Log("���� ����!!");

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��..."+Input.GetAxis("Horizontal"));
        }

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxisRaw("Horizontal"));
        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("�� �̵� ��..." + Input.GetAxisRaw("Vertical"));
        }
    }
    */

    /*
    void Start()
    {
        Vector3 vec = new Vector3(5, 0, 0);
        transform.Translate(vec);
    }
    */

    void Update()
    {
        //Vector3 vec = new Vector3(0, 0.1f, 0);
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(vec);
    }
}
