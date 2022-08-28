using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int hp = 100;
    private int power = 50;

    public void attack()
    {
        Debug.Log(this.power + "데미지를 입혔다."); // 이 클래스 안의 파워를 뜻함
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "데미지를 입었다.");
    }
}







public class UnityScript : MonoBehaviour
{

    int age;
    int ages = 10;
    List<int> numbers = new List<int> { 53, 853, 35, 854, 69 };
    Vector2 mypos = new Vector2(0, 0);

    // Start is called before the first frame update
    void Start()
    {
        age = 20;
        Debug.Log("my age is "+age);

        int year = 2020;

        year += age;

        Debug.Log("curruent age is " + year);

        int myHp = 1;

        if (myHp == 1)
        {
            myHp += 50;
        }

        Debug.Log("after: " + myHp);

        if (myHp >= 10)
        {
            myHp += 20;
        }

        else if (myHp <= 5)
        {
            myHp += 10;
        }

        else if (myHp <= 0)
        {
            myHp += 5;
        }

        Debug.Log("after: " + myHp);

        for (int i = 0; i<5; i++)
        {
            Debug.Log(numbers[i]);

        }
        SayHello();

        int youngAge = ages;
        int currentAge = NowAge(youngAge);
        int oldAge = NowAge(currentAge);

        Debug.Log("Final Ages: " + oldAge);

        Player myPlayer = new Player();
        myPlayer.attack();
        myPlayer.Damage(30);

        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);
    }

    // Update is called once per frame
    void Update()
    {
        //age++;
        //Debug.Log("my age is " + age);

        gameObject.transform.position = mypos;
        mypos.x += 0.01f;
        gameObject.transform.position = mypos;

    }

    void SayHello()
    {
        Debug.Log("Hello World");

    }

    int NowAge(int _ages)
    {
        Debug.Log("now my age is " + _ages);
        _ages++;
        return _ages;
    }
}
