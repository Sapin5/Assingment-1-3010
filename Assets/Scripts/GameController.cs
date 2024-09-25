using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject startScreen, gameOver, hpBar, 
                      Spawners, player, timer,
                      exit;
    public GameObject[] enemies;
    private bool playerActive = false;
    void Awake(){
        Time.timeScale = 0;
        gameOver.SetActive(false);
        hpBar.SetActive(false);
        Spawners.SetActive(false);
        player.SetActive(false);
        timer.SetActive(false);
    }
    // Start is called before the first frame update
    public void Onstart()
    {
        Time.timeScale = 1;
        startScreen.SetActive(false);
        exit.SetActive(false);
        hpBar.SetActive(true);
        Spawners.SetActive(true);
        player.SetActive(true);
        timer.SetActive(true);

        playerActive = true;
    }

    public void Restart(){
        PlayerHP.singleton.updateHP(10);
        Timer.curtime=0;
        gameOver.SetActive(false);
        SceneManager.LoadScene("Myscene");
    }

    public void ExitGame(){
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {   
        if(playerActive){    
            if(PlayerHP.singleton.Currenthp() <= 0){
                gameOver.SetActive(true);
                timer.SetActive(true);
            }
        }
    } 
}
