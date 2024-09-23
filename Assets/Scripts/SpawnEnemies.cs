using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public int intervalMax, intervalMin;
    public int timer = 100;
    private float counter = 0;
    private bool spawntime = true;
    // Start is called before the first frame update
    void Update()
    {

        int Rand1 = Random.Range(intervalMin, intervalMax);
        int Rand2 = Random.Range(intervalMin, intervalMax);

        if(Rand1 == Rand2 && spawntime == true)
        {
            Instantiate(enemyPrefab[Enemy()], 
                    new Vector3(transform.position.x, transform.position.y, 0),
                            transform.rotation);
            spawntime = false;
            Debug.Log("Enemy spawned");   
        }

        if(spawntime == false){
            counter += 1;
            if (counter >= timer){
                spawntime = true;
                counter = 0;
            }
            Debug.Log(counter);
        }
    }

    private int Enemy(){
        int ok = Mathf.Clamp(Random.Range(0, enemyPrefab.Length), 0, enemyPrefab.Length-1);
        return ok;
    }
}
