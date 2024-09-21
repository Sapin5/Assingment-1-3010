using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEnd : MonoBehaviour
{
    // death timer for explosion
    public float deathTimer = 1f;
    // runs on start
    void Start()
    {   
        // Destroys explosion after X seconds
        Destroy(gameObject, deathTimer);
    }
}
