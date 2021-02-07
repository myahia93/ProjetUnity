using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shark_move : MonoBehaviour {

	public float speed;
	public bool MoveRight;
	public static int cmpt=0;

	void Update () {
		
		if(MoveRight) {
			transform.Translate(2* Time.deltaTime * speed, 0,0);
			transform.localScale= new Vector2 (5,5);
 		}
		else{
			transform.Translate(-2* Time.deltaTime * speed, 0,0);
			transform.localScale= new Vector2 (-5,5);
		}
		cmpt++;

		if(cmpt%1500==0){
			
			if (MoveRight){
				MoveRight = false;
			}
			else{
				MoveRight = true;
			}	
			}
		
	}
}