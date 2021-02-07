using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuage_move : MonoBehaviour {

	public float speed;
	
	

	// Use this for initialization
	void Update () {
		// Use this for initialization
		
			transform.Translate(Time.deltaTime * speed, 0,0);
			transform.localScale= new Vector2 (1,1);

	}
}
