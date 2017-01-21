using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] private KeyCode left = KeyCode.A;
    [SerializeField] private KeyCode right = KeyCode.D;
    [SerializeField] private Vector2 elipseOrigin;
    [SerializeField] private Vector2 elipse;
    [SerializeField] private float movementSpeed = 1.0f;

    [SerializeField] private new Rigidbody rigidbody;
    [SerializeField] private new Collider collider;

    [SerializeField] private float alpha;
    
    void Start()
    {
        collider = GetComponent<Collider>();
        rigidbody = GetComponent<Rigidbody>();
    }

    float normalizeAngle(float angle)
    {
        return Mathf.Atan2(Mathf.Sin(angle), Mathf.Cos(angle));
    }

    // Update is called once per frame
    void Update () {
        Vector3 pos = rigidbody.position;
        alpha = Mathf.Atan2((pos.z - elipseOrigin.y) / elipse.y, (pos.x - elipseOrigin.x) / elipse.x);// *180.0f/Mathf.PI;

        // Update the player input
        if (Input.GetKey(left))
            alpha -= movementSpeed * Time.deltaTime;

        if (Input.GetKey(right))
            alpha += movementSpeed * Time.deltaTime;

        // Update the position based on an elipse
        pos.x = elipseOrigin.x + (elipse.x * Mathf.Cos(alpha));
        pos.y = 0.0f;
        pos.z = elipseOrigin.y + (elipse.y * Mathf.Sin(alpha));

        rigidbody.position = pos;
	}
}
