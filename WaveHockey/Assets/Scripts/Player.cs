using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] private KeyCode left = KeyCode.A;
    [SerializeField] private KeyCode right = KeyCode.D;
    [SerializeField] private Vector2 elipseOrigin;
    [SerializeField] private Vector2 elipse;
    [SerializeField] private float movementSpeed = 10.0f;

    [SerializeField] private Rigidbody rigidBody;
    [SerializeField] private Collider collider;
    private Player[] players;

    [SerializeField] private float alpha, otherAngle;
    
    void Start()
    {
        players = FindObjectsOfType<Player>();
        collider = GetComponent<Collider>();
        rigidBody = GetComponent<Rigidbody>();
    }

    float normalizeAngle(float angle)
    {
        return Mathf.Atan2(Mathf.Sin(angle), Mathf.Cos(angle));
    }

    // Update is called once per frame
    void Update () {
        Vector3 oldPos = transform.position;

        // Update the player input
        if (Input.GetKey(left))
            alpha -= movementSpeed * Time.deltaTime;

        if (Input.GetKey(right))
            alpha += movementSpeed * Time.deltaTime;

        // Update the position based on an elipse
        Vector3 pos = new Vector3();
        pos.x = elipseOrigin.x + (elipse.x * Mathf.Cos(alpha));
        pos.z = elipseOrigin.y + (elipse.y * Mathf.Sin(alpha));

        alpha = normalizeAngle(alpha);

        //float ratio = Mathf.Min(elipse.x, elipse.y) / Mathf.Max(elipse.x, elipse.y);
        otherAngle = Mathf.Atan2(elipse.y / (pos.z - elipseOrigin.y), elipse.x / (pos.x - elipseOrigin.x));// *180.0f/Mathf.PI;
        
        transform.position = pos;

        // Test if the player collided with another player
        /*foreach(Player player in players) {
            if(player == this)
                continue;
            
            if (collider.bounds.Intersects(player.collider.bounds)) {
                // If it did, revert to the old values and break
                transform.position = oldPos;
                alpha = oldAlpha;
                break;
            }
        }*/
        
	}

    /*private void OnCollisionEnter(Collision collision)
    {
        alpha = oldAlpha;
    }*/
}
