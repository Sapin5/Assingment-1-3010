using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public int intervalMax, intervalMin;
    public int timer = 100;
    private float counter = 0;
    // Start is called before the first frame update
    void Update()
    {

        int Rand1 = Random.Range(intervalMin, intervalMax);
        int Rand2 = Random.Range(intervalMin, intervalMax);
        counter += 1;
        if(counter >=timer){
            counter = 0;
            if(Rand1 == Rand2)
            {
                Instantiate(enemyPrefab[Enemy()], 
                        new Vector3(transform.position.x, transform.position.y, 0),
                             transform.rotation);
            }
        }
        
    }

    private int Enemy(){
        int ok = Mathf.Clamp(Random.Range(0, enemyPrefab.Length), 0, enemyPrefab.Length-1);
        return ok;
    }
}
