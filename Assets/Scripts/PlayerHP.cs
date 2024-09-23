using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
// Exlposion gameobjegt
    public GameObject explosionGo;
    
    //Player HP
    private static int hp = 10;

    // Allows other Scripts to access HP
    public static PlayerHP singleton;

    //Sets singleton to this game object
    void Awake(){
        singleton = this;
    }

    public void Update(){
        Debug.Log(hp);
    }

    // On collsion with Enemy loses HP
    private void OnCollisionEnter2D(Collision2D collision){
        // Checks if object collided with was an enemy
        if(collision.gameObject.CompareTag("Enemy")|| 
            collision.gameObject.CompareTag("Bullet")){
            // Reduces HP
            hp-=1;
        }  
        boom(hp);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        // Checks if object collided with was an enemy
        if(collision.gameObject.CompareTag("Enemy")|| 
            collision.gameObject.CompareTag("Bullet")){
            // Reduces HP
            hp-=1;
        }
        boom(hp);
    }

    public void boom(int hp){
        if(hp == 0){
            // Creates new explosion object
            Instantiate(explosionGo, transform.position, transform.rotation);
        }
    }

    public int Currenthp(){
        return hp;
    }
}
