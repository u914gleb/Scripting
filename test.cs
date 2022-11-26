using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    //Здоровье //NPS
    public int health = 5;
    //Уровень //NPS
    public int level = 1;
    //Скорость //NPS
    public float speed = 1.2f;
    // Start is
    // called before the first frame update
    void Start()
    {
        health = +level;
        print("Здоровье игрока:" + health);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z +=speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
