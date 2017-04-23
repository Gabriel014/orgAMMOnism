using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObjects : MonoBehaviour {

    public float interval;
    public GameObject objectToInstantiate;

    int difficulty = 0;

    public float max, min;

	// Use this for initialization
	void Start () {
        InvokeRepeating("DifficultyIncreaser", 0f, interval);
	}

    void DifficultyIncreaser()
    {
        difficulty += 1;
        if (difficulty <= 10) Invoke("InstantiateObject", 0f);
        else if (difficulty > 10 && difficulty <= 25)
        {
            Invoke("InstantiateObject", 0f);
            Invoke("InstantiateObject", 0.5f);
        }
        else if (difficulty > 25 && difficulty <= 50)
        {
            Invoke("InstantiateObject", 0f);
            Invoke("InstantiateObject", 0.5f);
            Invoke("InstantiateObject", 1f);
        }
        else
        {
            Invoke("InstantiateObject", 0f);
            Invoke("InstantiateObject", 0.5f);
            Invoke("InstantiateObject", 1f);
            Invoke("InstantiateObject", 1.5f);
        }
    }

    // Update is called once per frame
    void InstantiateObject()
    {
        GameObject clone = Instantiate(objectToInstantiate, new Vector3 (Random.Range(min, max), 6, 0), transform.rotation) as GameObject;
    }
}
