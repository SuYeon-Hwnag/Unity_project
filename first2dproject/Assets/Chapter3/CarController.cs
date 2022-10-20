using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    GameObject roulette;
    GameObject car;
    GameObject count;

    public int leftcount; // ���� ��ȸ ����
    public bool carmoveing;

    float speed = 0;     // �ڵ��� �ӵ�
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        this.roulette = GameObject.Find("roulette");
        leftcount = roulette.GetComponent<RouletteController>().carmovecount; // �귿��Ʈ�ѷ����� ���� carmovecount �� �������
    }

    // Update is called once per frame
    void Update()
    {

        if (carmoveing == true && Input.GetMouseButtonDown(0))
        {
            leftcount = roulette.GetComponent<RouletteController>().carmovecount; // �귿��Ʈ�ѷ����� ���� carmovecount �� �������
        }

        if (leftcount != 0)
        {

            if (Input.GetMouseButtonDown(0))
            {
                // ���콺�� ��ġ ��ǥ ����
                startPos = Input.mousePosition;
            }

            else if (Input.GetMouseButtonUp(0))
            {
                // ���콺�� ��ġ ��ǥ ����
                Vector2 endPos = Input.mousePosition;
                float swipeLength = endPos.x - startPos.x; // ���߰Ÿ�-ó���Ÿ� = �����ΰŸ�

                speed = swipeLength / 500.0f;
                GetComponent<AudioSource>().Play();

                leftcount--;
            }
            transform.Translate(speed, 0, 0);

            speed *= 0.98f;
        }
        }




            
}
