using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 회전 속도
    bool end = false;
    int carmovecount = 0; // 룰렛 돌릴 기회
    GameObject count;


    // Start is called before the first frame update
    void Start()
    {
        count = GameObject.Find("count");
    }

    // Update is called once per frame
    void Update()
    {
        // 클릭하면 회전한다.
        // Input.GetMouseButtonDown(0) -> 한 번만 클릭
        // Input.GetMouseButton(0) -> 쭉 클릭

        if (Input.GetMouseButton(0))
        {
            rotSpeed = 5;
            end = true;
        }
        // 회전 속도를 줄인다.
        rotSpeed *= 0.95f;

        // 회전 속도만큼 룰렛을 회전시킨다. 
        gameObject.transform.Rotate(0,0,rotSpeed);

        // 출력
        if (rotSpeed <= 0.01)
        {
            
            if (end == true)
            {
                if (gameObject.transform.eulerAngles.z > 330 || gameObject.transform.eulerAngles.z <= 30)

                {
                    Debug.Log("운수 나쁨");
                    count.GetComponent<Text>().text = "남은 횟수: 1";
                    carmovecount = 1;
                }
                else if (gameObject.transform.eulerAngles.z > 30 && gameObject.transform.eulerAngles.z <= 90)
                {
                    Debug.Log("운수 대통");
                    count.GetComponent<Text>().text = "남은 횟수: 2";
                    carmovecount = 2;
                }
                else if (gameObject.transform.eulerAngles.z > 90 && gameObject.transform.eulerAngles.z <= 150)
                {
                    Debug.Log("운수 매우 나쁨");
                    count.GetComponent<Text>().text = "남은 횟수: 1";
                    carmovecount = 1;
                }
                else if (gameObject.transform.eulerAngles.z > 150 && gameObject.transform.eulerAngles.z <= 210)
                {
                    Debug.Log("운수 보통");
                    count.GetComponent<Text>().text = "남은 횟수: 3";
                    carmovecount = 3;
                }
                else if (gameObject.transform.eulerAngles.z > 210 && gameObject.transform.eulerAngles.z <= 270)
                {
                    Debug.Log("운수 조심");
                    count.GetComponent<Text>().text = "남은 횟수: 2";
                    carmovecount = 2;
                }
                else
                {
                    Debug.Log("운수 좋음");
                    count.GetComponent<Text>().text = "남은 횟수: 4";
                    carmovecount = 4;
                }
                end = false;
            }
        }
    }
}
