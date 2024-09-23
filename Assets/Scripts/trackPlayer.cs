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
    public float radian, evenmoremath;
	public Quaternion target;
	public int index;
	public bool isBot;
    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float[] player = {playerObj.transform.position.x,
					playerObj.transform.position.y};

		float[] enemy = {transform.position.x,
                         transform.position.y};

        float[] temp = angle(player, enemy);
		evenmoremath = rotation(player, enemy, temp[2]);
		targetting(evenmoremath);
    }

	public float[] angle(float[] player, float[] enemy){
		float xvalue = player[0] - enemy[0];
		float yvalue = player[1] - enemy[1];

		radian = MathF.Atan(yvalue/xvalue);

		float[] output = {xvalue, yvalue, radian};

		return output;
	}

	public float rotation(float[] player, float[] enemy, float radian){

		if(isBot){
			if(player[0] > enemy[0] && player[1] > enemy[1]){
				evenmoremath = ((float)radian*Mathf.Rad2Deg) - 90;
			}else{
				evenmoremath =  ((float)radian*Mathf.Rad2Deg) + 90;
			}
		}else{
			if(player[0] < enemy[0] && player[1] < enemy[1]){
				evenmoremath = -1*(((float)radian*Mathf.Rad2Deg) - 90);
			}else if(player[0] < enemy[0] && player[1] > enemy[1]){
				evenmoremath = ((float)radian*Mathf.Rad2Deg) + 90;
			}else{
				evenmoremath =  -1*(((float)radian*Mathf.Rad2Deg) + 90);
			}
		}

		return evenmoremath;
	}

	public void targetting(float rotation)
	{
		target = (isBot) ? Quaternion.Euler(0, 0, rotation):
							Quaternion.Euler(0, 0, -1*rotation-180); 
		index = Mathf.Clamp(Mathf.FloorToInt(rotation / -5) + 5, 0, gunPos.Length - 1);
		/*
		Debug.Log(rotation+ " "+
					rotation / -5+ " " +
					Mathf.FloorToInt(rotation / -5)+ " " +
					Mathf.Clamp(Mathf.FloorToInt(rotation / -5) + 5, 0, gunPos.Length - 1));
		*/

		bodyRenderer.sprite = gunPos[index];
	}

}


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