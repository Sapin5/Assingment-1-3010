using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject startScreen = null;
    public GameObject gameOver = null;
    public GameObject hpBar = null;
    public GameObject Spawners = null;
    public GameObject player = null;
    public GameObject timer = null;
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
        hpBar.SetActive(true);
        Spawners.SetActive(true);
        player.SetActive(true);
        timer.SetActive(true);

        playerActive = true;
    }

    public void Restart(){
        PlayerHP.singleton.updateHP(10);
        gameOver.SetActive(false);
        SceneManager.LoadScene("Myscene");
    }

    // Update is called once per frame
    void Update()
    {   
        if(playerActive){    
            if(PlayerHP.singleton.Currenthp() <= 0){
                gameOver.SetActive(true);
            }
        }
    } 
}
