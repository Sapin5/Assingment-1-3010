using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject startScreen = null;
    public GameObject gameOver = null;
    void Awake(){
        Time.timeScale = 0;
        gameOver.SetActive(false);
    }
    // Start is called before the first frame update
    public void Onstart()
    {
        Time.timeScale = 1;
        startScreen.SetActive(false);
    }

    public void Restart(){
        PlayerHP.singleton.updateHP(10);
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerHP.singleton.Currenthp() <= 0){
            gameOver.SetActive(true);
        }
    }
}
