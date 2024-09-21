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

    public void OnCollisionEnter2D(Collision2D collision){

        if(collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Got hit");
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Got hit");
            Destroy(gameObject);
        }
    }
}
