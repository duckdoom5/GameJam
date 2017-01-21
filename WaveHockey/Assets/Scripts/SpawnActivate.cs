using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnActivate : MonoBehaviour {

    public GameObject _energy;
    public GameObject _gameController;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    public bool Activate()
    {
        if (transform.childCount <= 0)
        {
            var energyClone = Instantiate(_energy, transform.position, Quaternion.identity);
            energyClone.transform.parent = transform;
            return true;
        }
        else
        {
            return false;
        }
    }
}
