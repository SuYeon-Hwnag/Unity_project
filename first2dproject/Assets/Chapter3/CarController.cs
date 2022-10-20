using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    GameObject roulette;
    GameObject car;
    GameObject count;

    public int leftcount; // 남은 기회 세기
    public bool carmoveing;

    float speed = 0;     // 자동차 속도
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        this.roulette = GameObject.Find("roulette");
        leftcount = roulette.GetComponent<RouletteController>().carmovecount; // 룰렛컨트롤러에서 나온 carmovecount 값 갖고오기
    }

    // Update is called once per frame
    void Update()
    {

        if (carmoveing == true && Input.GetMouseButtonDown(0))
        {
            leftcount = roulette.GetComponent<RouletteController>().carmovecount; // 룰렛컨트롤러에서 나온 carmovecount 값 갖고오기
        }

        if (leftcount != 0)
        {

            if (Input.GetMouseButtonDown(0))
            {
                // 마우스의 위치 좌표 저장
                startPos = Input.mousePosition;
            }

            else if (Input.GetMouseButtonUp(0))
            {
                // 마우스의 위치 좌표 저장
                Vector2 endPos = Input.mousePosition;
                float swipeLength = endPos.x - startPos.x; // 나중거리-처음거리 = 움직인거리

                speed = swipeLength / 500.0f;
                GetComponent<AudioSource>().Play();

                leftcount--;
            }
            transform.Translate(speed, 0, 0);

            speed *= 0.98f;
        }
        }




            
}
