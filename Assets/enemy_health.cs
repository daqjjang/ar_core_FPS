using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_health : MonoBehaviour
{
    // Start is called before the first frame update
    public float enemy_h = 100.0f;
//    public float damage_Helath;
    public arcore_enemy enemy_status;
    public bool isBody = false;
    public bool isHead = false;
    float body_dam = 20.0f;
    float head_dam = 100.0f;
    void Start()
    {
        enemy_status = GetComponent<arcore_enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isBody==true)
        {
            DeductHelath(body_dam);
        }
        if(isHead==true)
        {
            DeductHelath(head_dam);

        }
    }
    public void DeductHelath(float damage_Helath)
    {
        enemy_h -= damage_Helath;
        if (enemy_h <= 0)
        {
            enemy_status.duck_status = 99;
            enemy_status.enemy_death();
        }


    }
}
