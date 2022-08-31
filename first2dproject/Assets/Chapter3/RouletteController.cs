using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // ȸ�� �ӵ�
    bool end = false;
    int carmovecount = 0; // �귿 ���� ��ȸ
    GameObject count;


    // Start is called before the first frame update
    void Start()
    {
        count = GameObject.Find("count");
    }

    // Update is called once per frame
    void Update()
    {
        // Ŭ���ϸ� ȸ���Ѵ�.
        // Input.GetMouseButtonDown(0) -> �� ���� Ŭ��
        // Input.GetMouseButton(0) -> �� Ŭ��

        if (Input.GetMouseButton(0))
        {
            rotSpeed = 5;
            end = true;
        }
        // ȸ�� �ӵ��� ���δ�.
        rotSpeed *= 0.95f;

        // ȸ�� �ӵ���ŭ �귿�� ȸ����Ų��. 
        gameObject.transform.Rotate(0,0,rotSpeed);

        // ���
        if (rotSpeed <= 0.01)
        {
            
            if (end == true)
            {
                if (gameObject.transform.eulerAngles.z > 330 || gameObject.transform.eulerAngles.z <= 30)

                {
                    Debug.Log("��� ����");
                    count.GetComponent<Text>().text = "���� Ƚ��: 1";
                    carmovecount = 1;
                }
                else if (gameObject.transform.eulerAngles.z > 30 && gameObject.transform.eulerAngles.z <= 90)
                {
                    Debug.Log("��� ����");
                    count.GetComponent<Text>().text = "���� Ƚ��: 2";
                    carmovecount = 2;
                }
                else if (gameObject.transform.eulerAngles.z > 90 && gameObject.transform.eulerAngles.z <= 150)
                {
                    Debug.Log("��� �ſ� ����");
                    count.GetComponent<Text>().text = "���� Ƚ��: 1";
                    carmovecount = 1;
                }
                else if (gameObject.transform.eulerAngles.z > 150 && gameObject.transform.eulerAngles.z <= 210)
                {
                    Debug.Log("��� ����");
                    count.GetComponent<Text>().text = "���� Ƚ��: 3";
                    carmovecount = 3;
                }
                else if (gameObject.transform.eulerAngles.z > 210 && gameObject.transform.eulerAngles.z <= 270)
                {
                    Debug.Log("��� ����");
                    count.GetComponent<Text>().text = "���� Ƚ��: 2";
                    carmovecount = 2;
                }
                else
                {
                    Debug.Log("��� ����");
                    count.GetComponent<Text>().text = "���� Ƚ��: 4";
                    carmovecount = 4;
                }
                end = false;
            }
        }
    }
}
