using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveEnemies : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(transform.transform.position.x <= -10){
            Destroy(gameObject);
        }
    }
}
