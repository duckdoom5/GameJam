using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public static GameObject Ball1;
    public static GameObject Ball2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void Resetting()
    {
            Ball1.gameObject.SetActive(true);
            Ball1.transform.position = new Vector3(0, 2, 0);

            Ball2.gameObject.SetActive(true);
            Ball2.transform.position = new Vector3(0, 2, 0);
    }
}