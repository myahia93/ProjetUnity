using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptTir : MonoBehaviour
{
    public float speed;
    //public GameObject PassBox;

    // Use this for initialization
    void Update () {
        if (transform.position.x < 0) {
            transform.Translate(2*Time.deltaTime * speed, 0,0);
        }else
        {
            transform.Translate(-2*Time.deltaTime * speed, 0,0);
        }
        /*if (PassBox.GetComponent<Text>().text=="CHOC") {
            if(Input.GetKeyDown(KeyCode.RightArrow)) {
                PassBox.GetComponent<Text>().text="SUCCES";
            }
        }*/
    }

    void OnTriggerEnter2D(Collider2D collider){
        //PassBox.GetComponent<Text>().text="CHOC";

        /*if(Input.GetKeyDown(KeyCode.RightArrow)) {
            if (collider.gameObject.tag == "tir") {
                Destroy(collider.gameObject);
            }
        }*/
    }
}
