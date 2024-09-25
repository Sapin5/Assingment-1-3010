using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public GameObject hpbar;
    private int hp;
    private float totalhp;
    void Awake(){
        hp = GetComponent<RemoveEnemies>().hp;
        totalhp = hp;
    }

    public void TakeEnemyDmg(int damage){
        hp-=damage;
        hpbar.transform.localScale = new Vector2(hp/totalhp, 1);
    }
}
