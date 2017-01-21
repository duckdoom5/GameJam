using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupEnergy : MonoBehaviour {

    Shoot playerInfo;
    public int energyGain;

	// Use this for initialization
	void Start () {
        playerInfo = GetComponentInParent<Shoot>();
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Energy")
            return;
        if(playerInfo.energy<100)
            playerInfo.energy += energyGain;
    }
}
