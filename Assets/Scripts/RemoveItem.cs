using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class RemoveItem : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.name== "wall" || collision.gameObject.CompareTag("Player")){
            Destroy(gameObject);
        }
    }
}
