using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public GameObject hpbar;
    private int hp;
    void Awake(){
        hp = GetComponent<RemoveEnemies>().hp;
    }

    public void TakeEnemyDmg(int damage){
        Debug.Log("imhit");
        hp-=damage;
        Debug.Log(hp/10f);
        hpbar.transform.localScale = new Vector2(hp/10f, 1);
    }
}
