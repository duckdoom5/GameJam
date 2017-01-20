using UnityEngine;
using UnityEngine.Networking;

public class PlayerMovement : NetworkBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
            return;
        float x = Input.GetAxis("Horizontal")*.1f;
        float z = Input.GetAxis("Vertical") * .1f;
        transform.Translate(x, 0, z);
	}
}
