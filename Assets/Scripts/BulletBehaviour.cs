using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
        // Bullet explosion for whenever it hits anything
    public GameObject explosionGo;

    // Whenever a bullet collides with anything it creates an explosion game object
    private void OnTriggerEnter2D(Collider2D collision){
        // Creates explosion game object
        Instantiate(explosionGo, transform.position, transform.rotation);
        // Removes this Gameobject from the game
        Destroy(gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collision){
        // Creates explosion game object
        Instantiate(explosionGo, transform.position, transform.rotation);
        // Removes this Gameobject from the game
        Destroy(gameObject);
    }
}
