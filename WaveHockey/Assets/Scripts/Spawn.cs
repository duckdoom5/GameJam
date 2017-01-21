using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    
    public float _spawnrate;
    private float _cooldown;

	// Use this for initialization
	void Start () {
        _cooldown = _spawnrate;
	}
	
	// Update is called once per frame
	void Update () {
        _cooldown -= Time.deltaTime;

        if (_cooldown <= 0.0f)
        {
            SpawnEnergy();
            ResetTimer();
        }
	}

    private bool SpawnEnergy()
    {
        GameObject[] spawns = GameObject.FindGameObjectsWithTag("Spawn");

        System.Random rand = new System.Random();
        int spawnSelect = rand.Next(spawns.Length - 1);
        Debug.Log(spawnSelect);

        return spawns[spawnSelect].GetComponent<SpawnActivate>().Activate();
    }

    public void ResetTimer()
    {
        _cooldown = _spawnrate;
    }
}
