using System;
using UnityEngine;

public class ArtController : MonoBehaviour
{
    public Sprite[] idle, move, dead;
    public SpriteRenderer bodyRenderer;
    private int test;
    private int test2 =0;
    public int delay;
    public MovementPlayer touchingGround;

    // Update is called once per frame
    void Update()
    {
        test2+=1;
        if(PlayerHP.singleton.Currenthp() <= 0){
            if(test2%delay == 0){
                test+=1;
            }
            if(test > dead.Length-1){
                test = 0;
                test2 = 0;
            }
            bodyRenderer.sprite = dead[test];
        }else{ 
            if(Input.GetAxis("Horizontal") != 0)
            {
                if(test2%delay/2 == 0){
                    test+=1;
                }
                if(test > move.Length-1){
                    test = 0;
                    test2 = 0;
                }
                bodyRenderer.sprite = move[test];
            }else{
                if(test2%delay == 0){
                    test+=1;
                }
                if(test > idle.Length-1){
                        test = 0;
                        test2 = 0;
                }
                bodyRenderer.sprite = idle[test];
            }
        }
    }
}
