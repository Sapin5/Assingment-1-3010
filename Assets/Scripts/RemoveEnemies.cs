using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveEnemies : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.transform.position.x <= -9){
            Destroy(gameObject);
        }
    }
}
