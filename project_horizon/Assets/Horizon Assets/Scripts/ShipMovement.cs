using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour {
    Rigidbody shipRigidBody;
    public float timeBeforeFall;
    Transform shipPosition;
	// Use this for initialization
	void Start () {
        shipRigidBody = GetComponent<Rigidbody>();
        shipPosition = GetComponent<Transform>();
        timeBeforeFall = 0;
    }
	
	// Update is called once per frame
	void Update () {
        timeBeforeFall += Time.deltaTime;

        if(timeBeforeFall >= 5)
        {
            shipRigidBody.useGravity = true;
            shipRigidBody.isKinematic = false;
        }
        if (timeBeforeFall >= 10)
        {
            shipRigidBody.isKinematic = true;
            shipRigidBody.useGravity = false;
            timeBeforeFall = 0;
            shipPosition.transform.position = new Vector3(0, 110, 50);
        }
    }
}
