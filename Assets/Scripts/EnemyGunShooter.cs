using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class EnemyGunShooter : MonoBehaviour
{
    float[] AdjustLocations = {-0.14f, -0.12f};
    private int lastindx, currindex;


    //subtract .2 from postion, add .2 from position
    // Start is called before the first frame update
    void Start()
    {
        currindex = trackPlayer.index;
    }

    // Update is called once per frame
    void Update()
    {
        lastindx = currindex;
        currindex = trackPlayer.index;
        Debug.Log(lastindx+"<- Last   Current ->"+currindex);
        if(lastindx>currindex){
            transform.position = transform.position - new Vector3(0.15f, 0f, 0f);
        }else if(lastindx<currindex){
            transform.position = transform.position + new Vector3(0.15f, 0f, 0f);
        }else if(lastindx==currindex){
            Debug.Log("I will do nothing");
        }
    }
}
