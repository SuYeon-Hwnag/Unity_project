using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirecto : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("distacne");

    }

    // Update is called once per frame
    void Update()
    {
        // ��߰� ���� �Ÿ��� ���ϴ� ����
        float length = flag.transform.position.x - car.transform.position.x;

        //alt + enter�� ����Ƽ ���� ��� F�� �ϸ� �⺻������ �Ҽ��� �ι�°�ڸ����� ǥ��
        distance.GetComponent<Text>().text = "���� �Ÿ�: "+ length.ToString("F2"); //alt + enter�� ����Ƽ ���� ���
    }
}
