using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveEnemies : MonoBehaviour
{
    // Update is called once per frame

    public int hp = 10;
    void Update()
    {
        if(transform.transform.position.x <= -10){
            Destroy(gameObject);
        }else if(hp == 0){
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("PlayerBullet"))
        {
            hp--;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("PlayerBullet"))
        {
            hp--;
        }
    }
}
