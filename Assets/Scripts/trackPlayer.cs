using UnityEngine;
using System;
using UnityEngine.PlayerLoop;
using System.Runtime.CompilerServices;

public class trackPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject playerObj = null;
	public Sprite[] gunPos;
	public SpriteRenderer bodyRenderer;
    private float radian, evenmoremath;
    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float[] player = {playerObj.transform.position.x,
						  playerObj.transform.position.y};

		float[] enemy = {this.transform.position.x,
                         this.transform.position.y};

        float[] temp = angle();
		evenmoremath = rotation(player, enemy, temp[2]);
		targetting(evenmoremath);
    }

	public float[] angle(){
		float xvalue = playerObj.transform.position.x - 
						this.transform.position.x;
		float yvalue = playerObj.transform.position.y - 
						this.transform.position.y;

		radian = MathF.Atan(yvalue/xvalue);

		float[] output = {xvalue, yvalue, radian};

		return output;
	}

	public float rotation(float[] player, float[] enemy, float radian){
		if(player[0] > enemy[0] && player[1] > enemy[1]){
			evenmoremath = ((float)radian*Mathf.Rad2Deg) - 90;
		}else{
			evenmoremath =  ((float)radian*Mathf.Rad2Deg) + 90;
		}
		return evenmoremath;
	}

	public void targetting(float Rotation){
		
		/*
		// Create a quaternion to rotate the enemy towards the target angle
		Quaternion target = Quaternion.Euler(0, 0, Rotation);
		// Smoothly rotate the enemy towards the target using Slerp
		transform.rotation = Quaternion.Slerp(transform.rotation, 
											  target, Time.deltaTime*5);
		
		float ROt;
		if(Rotation <= 180f){
			ROt = Rotation;
		}else{
			ROt = Rotation - 360f;
		}
		*/
		if(Rotation>25){
			bodyRenderer.sprite = gunPos[0];

		}else if(Rotation<=25 && Rotation>20){
			bodyRenderer.sprite = gunPos[2];

		}else if(Rotation<=20 && Rotation>15){

			bodyRenderer.sprite = gunPos[4];
		}else if(Rotation<=15 && Rotation>10){
			bodyRenderer.sprite = gunPos[6];

		}else if(Rotation<=10 && Rotation>5){
			bodyRenderer.sprite = gunPos[8];

		}else if(Rotation<=5 && Rotation>0){
			bodyRenderer.sprite = gunPos[10];

		}else if(Rotation<=0 && Rotation>-5){
			bodyRenderer.sprite = gunPos[12];

		}else if(Rotation<=-10 && Rotation>-15){
			bodyRenderer.sprite = gunPos[14];

		}else if(Rotation<=-15 && Rotation>-20){
			bodyRenderer.sprite = gunPos[16];

		}else if(Rotation<=-20 && Rotation>-25){
			bodyRenderer.sprite = gunPos[18];

		}else if(Rotation<=-25){
			bodyRenderer.sprite = gunPos[20];
		}
	}

}
