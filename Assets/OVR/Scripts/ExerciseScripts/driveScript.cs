using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driveScript : MonoBehaviour {

    public float speed = 10f;
	
	// Update is called once per frame
	void Update () {
		if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger)) {
            transform.position += transform.forward * Time.deltaTime * speed;
        }

        Vector2 res = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad, OVRInput.Controller.RTrackedRemote);

        // Left
        if (res.x < 0)
        {
            transform.Rotate(0, -1f, 0);
        }
        else if (res.x > 0) // Right
        {
            transform.Rotate(0, 1f, 0);
        }

	}
}
