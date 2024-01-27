using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //�������� NPC
    public int health = 5;
    //������� NPC
    public int level = 2;
    //�������� NPC
    public float speed = 1.2f;
    float accel;
    // Start is called before the first frame update
    void Start()
    {
        accel = Random.Range(0.1f, 0.5f);
        health *= level;
        print("������� NPC: " + level+ "" + " �������� NPC: " + health);
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
