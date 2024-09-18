using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class EnemyGunShooter : MonoBehaviour
{
    private int lastindx, currindex;
    
    public trackPlayer index;

    // Start is called before the first frame update
    void Start()
    {
        currindex = index.index;
    }

    // Update is called once per frame
    void Update()
    {
        float adjustLoc = (index.isBot) ? 0.15f: 0.075f;

        lastindx = currindex;
        currindex = index.index;
        Debug.Log(lastindx+"<- Last   Current ->"+currindex);
        if(lastindx>currindex){
            transform.position = transform.position - new Vector3(adjustLoc, 0f, 0f);
        }else if(lastindx<currindex){
            transform.position = transform.position + new Vector3(adjustLoc, 0f, 0f);
        }else if(lastindx==currindex){
            Debug.Log("I will do nothing");
        }
    }
}
