using System;
using UnityEngine;

public class EnemyGunShooter : MonoBehaviour
{
    private int lastindx, currindex;
    
    public Rigidbody2D projectilePrefab;

    public float firerate = 0.3f;
    private float currentFireTimer = 0;
    public float shootForce = 1f;
    public float bulletDeathTimer = 1f;
    public GameObject Enemy;
    public trackPlayer index;

    // Start is called before the first frame update
    void Start()
    {
        currindex = index.index;
    }

    // Update is called once per frame
    void Update()
    {
        float adjustLoc = index.isBot ? 0.15f: 0.075f;

        lastindx = currindex;
        currindex = index.index;
        
        if(lastindx>currindex){
            transform.position = transform.position - new Vector3(adjustLoc, 0f, 0f);
        }else if(lastindx<currindex){
            transform.position = transform.position + new Vector3(adjustLoc, 0f, 0f);
        }else if(lastindx==currindex){
    
        }


        currentFireTimer+=.01f;

        // every .3 seconds will allow the a bullet to be spawned
        if (currentFireTimer >= firerate) {
            // Calls function to fire bullet
            FireOneBullet();
            // Resets timer to 0 to restart cycle
            currentFireTimer = 0;
        }
    }


    private void FireOneBullet() {
        // Spawns bullet
        Rigidbody2D rg = Instantiate<Rigidbody2D>(projectilePrefab, transform.position,
                                                     index.target);
        // Applies force to bullet to proell it in a direction 
        rg.AddRelativeForce(10*shootForce * Vector2.up);
        // Removes Bulllet afeter Given amount of time
        Destroy(rg.gameObject, bulletDeathTimer+10);
    }
}
