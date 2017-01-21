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
            Debug.Log("Pressed");
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
	}

    public void Shooting()
    {
        Vector3 dir = ball.transform.position - player.transform.position;
        dir.Normalize();

        ball.GetComponent<Rigidbody>().AddForce(dir*force);
    }

    
}
