using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour { 

    public float speed;

    void Awake()
    {
        if (gameObject.tag == "Enemy") gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, Random.Range(-15, 15)));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 1) * speed * Time.deltaTime;
        if (transform.position.y < -15) Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // if (collider.name == "Player") //call GameOver
        if (collider.tag == "Projectile")
        {
            Destroy(collider.gameObject);
            Destroy(gameObject);
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score", 0) + 50);
        }
    }
}
