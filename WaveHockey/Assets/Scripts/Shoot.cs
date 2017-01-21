using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject ball;
    public GameObject player;
    public int force;
    public int energy = 0;
    public float cooldown;
    private float counter;
    private Vector3 dir;
    private float dist;
    public KeyCode keycode;
    public KeyCode specialKeyCode;

	// Use this for initialization
	void Start () {
        counter = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

        counter -= Time.deltaTime;

        if (Input.GetKeyDown(keycode) && counter <= 0.0f)
        {
            Shooting();
            counter = cooldown;
            
        }



        if (Input.GetKeyDown(keycode) && counter <= 0.0f && energy == 100)
        {
            int tempforce = force;
            force *= 2;
            Shooting();
            force = tempforce;
            counter = cooldown;
            energy = 0;
        }

        Vector3 dir = ball.transform.position - player.transform.position;
        float dist = Vector3.Distance(ball.transform.position, player.transform.position);
        dir.Normalize();
        Debug.DrawLine(player.transform.position, player.transform.position+ dir*force/dist);
    }

    public void Shooting()
    {
        
        Vector3 dir = ball.transform.position - player.transform.position;
        dir.Normalize();
        float dist = Vector3.Distance(ball.transform.position, player.transform.position);
        ball.GetComponent<Rigidbody>().AddForce(dir*force/dist);
    }

    
}
