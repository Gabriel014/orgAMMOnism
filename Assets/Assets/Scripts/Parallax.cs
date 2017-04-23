using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public float interval;
    public GameObject objectToInstantiate;
    void Start()
    {
        InvokeRepeating("InstantiateParallax", 0f, interval);
    }

    void InstantiateParallax()
    {
        GameObject clone = Instantiate(objectToInstantiate) as GameObject;
    }
}