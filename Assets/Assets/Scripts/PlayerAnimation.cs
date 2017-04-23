﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    public float speed = 0.0f;

    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
