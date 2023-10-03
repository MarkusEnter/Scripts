using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcScript : MonoBehaviour
{
    //значение перемен
    public int health = 4;
    public int level = 1;
    public float speed = 0.5f;
    Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
       //обновление здоровья
       health += level;
       //вывод здоровья
       print(health);
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
