using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Здоровье NPC
    public int health = 5;
    //Уровень NPC
    public int level = 2;
    //Скорость NPC
    public float speed = 1.2f;
    float accel;
    // Start is called before the first frame update
    void Start()
    {
        accel = Random.Range(0.1f, 0.5f);
        health *= level;
        print("Уровень NPC: " + level+ "" + " Здоровье NPC: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        speed += accel * Time.deltaTime;
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
