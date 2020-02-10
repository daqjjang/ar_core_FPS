using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arcore_enemy : MonoBehaviour {
    //public GameObject target;
    Animator duck;
    public float duck_status=0;
    public bool isHit = false;

    // Use this for initialization
	void Start () {

        duck= GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        float step = 0.2f * Time.deltaTime;
        if (duck_status == 0) { 
        duck.SetBool("Ismoving", true);
            duck_status = 1;
        }
        else if(duck_status==1)
        { 
        Vector3 cam_pos = GameObject.FindWithTag("MainCamera").transform.position;
        cam_pos = new Vector3(cam_pos.x, this.transform.position.y, cam_pos.z);
        this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, cam_pos, step);
            this.transform.LookAt(cam_pos, Vector3.up);
        }
    }
    public void enemy_death()

    {


        duck.SetBool("Dead", true);
        Destroy(this.gameObject, 5);

    }

}
