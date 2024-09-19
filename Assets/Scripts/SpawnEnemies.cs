using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public float interval = 100;
    private float counter = 0;
    // Start is called before the first frame update
    void Update()
    {
        counter += 1;
        if(counter >= interval){
            counter = 0;
            Instantiate(enemyPrefab[Enemy()],new Vector3(9, transform.position.y, 0), transform.rotation);
        }
        
    }

    private int Enemy(){
        int ok = Random.Range(0, enemyPrefab.Length);
        //Debug.Log(ok);
        return ok;
    }
}
