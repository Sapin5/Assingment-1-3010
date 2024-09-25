using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public float timer;
    private float counter = 0;
    private float timerinc = 0;
    // Start is called before the first frame update

    void Update()
    { 
        counter += Time.deltaTime;
        timerinc += Time.deltaTime;
        if (counter >= timer){
                Instantiate(enemyPrefab[Enemy()], new Vector3(transform.position.x,
                                    transform.position.y, 0), transform.rotation);
            counter = 0;
        }
    }
    private int Enemy(){
        int ok = Random.Range(0, enemyPrefab.Length);
        return ok;
    }
}
