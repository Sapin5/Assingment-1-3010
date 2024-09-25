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
        
        curtime+=Time.deltaTime;
        timer.GetComponent<TextMeshPro>().text = curtime.ToString("#.#");
    }
}
