using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject count;
    public float carposition; // �ڵ��� ����

    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        count = GameObject.Find("count");
    }

    // Update is called once per frame
    void Update()
    {
        // ��߰� ���� �Ÿ��� ���ϴ� ����
        // float length = flag.transform.position.x - car.transform.position.x;

        //alt + enter�� ����Ƽ ���� ��� F�� �ϸ� �⺻������ �Ҽ��� �ι�°�ڸ����� ǥ��
        // distance.GetComponent<Text>().text = "���� �Ÿ�: " + length.ToString("F2"); //alt + enter�� ����Ƽ ���� ���


    }
}
