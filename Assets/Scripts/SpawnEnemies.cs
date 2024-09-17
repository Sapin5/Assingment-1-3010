using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public float interval = 100;
    private float counter = 0;
    private float[] spawnLocations = {1f, -2f, -5f};
    // Start is called before the first frame update
    void Update()
    {
        counter += 1;
        if(counter >= interval){
            counter = 0;
            SpawnLocation();
            //Instantiate(enemyPrefab[0],new Vector3(9, (int)spawnLocations[1], 0), transform.rotation);
        }
        
    }

    private float SpawnLocation(){
        float ok = Random.Range(0, 3);
        //Debug.Log(ok);
        return ok;
    }
}
