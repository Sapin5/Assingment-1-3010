using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
        // Bullet explosion for whenever it hits anything
    public GameObject explosionGo;

    public bool playersBullet;

    // Whenever a bullet collides with anything it creates an explosion game object
    private void OnTriggerEnter2D(Collider2D collision){
        // Creates explosion game object

        if(playersBullet){
            Instantiate(explosionGo, transform.position, transform.rotation);
            // Removes this Gameobject from the game
            Destroy(gameObject);
        }else{
            if(collision.gameObject.CompareTag("Player") || 
                collision.gameObject.CompareTag("PlayerBullet") ||
                collision.gameObject.CompareTag("BoundryWall")){
                    Instantiate(explosionGo, transform.position, transform.rotation);
                    // Removes this Gameobject from the game
                    Destroy(gameObject);
                }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision){
        if(playersBullet){
            Instantiate(explosionGo, transform.position, transform.rotation);
            // Removes this Gameobject from the game
            Destroy(gameObject);
        }else{
            if(collision.gameObject.CompareTag("Player") || 
                collision.gameObject.CompareTag("PlayerBullet") ||
                collision.gameObject.CompareTag("BoundryWall")){
                    Instantiate(explosionGo, transform.position, transform.rotation);
                    // Removes this Gameobject from the game
                    Destroy(gameObject);
                }
        }
    }
}
