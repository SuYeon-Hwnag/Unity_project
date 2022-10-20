using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject count;
    public float carposition; // 자동차 ㅇㄷ

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
        // 깃발과 차의 거리를 구하는 공식
        // float length = flag.transform.position.x - car.transform.position.x;

        //alt + enter로 유니티 엔진 사용 F만 하면 기본적으로 소수점 두번째자리까지 표시
        // distance.GetComponent<Text>().text = "남은 거리: " + length.ToString("F2"); //alt + enter로 유니티 엔진 사용


    }
}
