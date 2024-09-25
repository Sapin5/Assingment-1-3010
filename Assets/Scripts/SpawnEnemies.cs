using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public float timer, minTime;
    private float counter = 0;
    private float timerinc = 0;
    private bool spawntime = true;
    // Start is called before the first frame update
    void Update()
    { 
        counter += Time.deltaTime;
        timerinc += Time.deltaTime;
        if (counter >= timer){
            spawntime = true;
                Instantiate(enemyPrefab[Enemy()], new Vector3(transform.position.x,
                                    transform.position.y, 0), transform.rotation);
            counter = 0;
        }

        if((int)timerinc%10 == 0 && timer>minTime){
            timer-=0.5f;
            timerinc=0;
        }
    }

    private int Enemy(){
        int ok = Random.Range(0, enemyPrefab.Length);
        return ok;
    }
}
