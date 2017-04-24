using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkText : MonoBehaviour {

    bool appearing;

	void Start () {
        InvokeRepeating("BlinkTextVoid", 0f, 0.5f);
	}

    void BlinkTextVoid()
    {
        if (appearing) appearing = false;
        else appearing = true;

        if (appearing) gameObject.SetActive(true);
        else gameObject.SetActive(false);

    }

    void Update()
    {
        if (Input.GetKeyDown("space")) Destroy(gameObject);

    }
}
