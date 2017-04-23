using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour {

    public float speed;

    void Awake()
    {
        gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, Random.Range(-15, 15)));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 1) * speed * Time.deltaTime;

        if (transform.position.y > 5f) Destroy(gameObject);
    }
}
