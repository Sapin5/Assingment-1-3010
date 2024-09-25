using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public static float curtime = 0;
    public GameObject timer;
    // Update is called once per frame
    void Update()
    {
        if(PlayerHP.singleton.Currenthp() >= 1){
            curtime+=Time.deltaTime;
            timer.GetComponent<TextMeshPro>().text = "Time: " + curtime.ToString("#.#");
        }else{
            timer.GetComponent<TextMeshPro>().text = "Time: " +curtime.ToString("#.#");
        }
    }
}
