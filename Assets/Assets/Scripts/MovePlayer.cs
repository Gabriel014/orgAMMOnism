using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public float speed;
    public float limitX, limitY;
	
	// Update is called once per frame
	void Update () {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;

        if (transform.position.x > limitX) transform.position = new Vector3(limitX, transform.position.y, transform.position.z);
        if (transform.position.x < -limitX) transform.position = new Vector3(-limitX, transform.position.y, transform.position.z);
        if (transform.position.y > limitY) transform.position = new Vector3(transform.position.x, limitY, transform.position.z);
        if (transform.position.y < -limitY) transform.position = new Vector3(transform.position.x, -limitY, transform.position.z);




    }
}
