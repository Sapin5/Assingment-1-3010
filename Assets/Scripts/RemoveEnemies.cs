using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveEnemies : MonoBehaviour
{
    // Update is called once per frame
    private EnemyHealthManager enemyHealthManager;
    public int hp = 10;
    void Awake(){
        enemyHealthManager = gameObject.GetComponent<EnemyHealthManager>();
    }

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
            enemyHealthManager.TakeEnemyDmg(1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("PlayerBullet"))
        {
            hp--;
            enemyHealthManager.TakeEnemyDmg(1);
        }
    }
}
