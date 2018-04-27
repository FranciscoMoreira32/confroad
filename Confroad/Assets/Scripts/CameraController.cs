using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Player;
    private Vector3 offset;

    // Use this for initialization
    void Start () {
        offset = transform.position - Player.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = Player.transform.position + offset;
    }

    public float smooth = 2.0F;
    public float tiltAngle = 30.0F;

    void Update()
    {
        float tiltAroundY = Input.GetAxis("Horizontal") * tiltAngle;
        Quaternion target = Quaternion.Euler(0, tiltAroundY, 0 );
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}
