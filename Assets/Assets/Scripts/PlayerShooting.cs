 using UnityEngine;
 using System.Collections;
 
 public class PlayerShooting : MonoBehaviour
{
    public GameObject projectile;
    public float fireRate = 0.5F;
    private float nextFire = 0.0F;

    void Update()
    {
        if (Input.GetKeyDown("space") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject clone = Instantiate(projectile, new Vector3(GameObject.Find("Player").transform.position.x, GameObject.Find("Player").transform.position.y + 0.75f, 0), transform.rotation) as GameObject;
        }
    }
}