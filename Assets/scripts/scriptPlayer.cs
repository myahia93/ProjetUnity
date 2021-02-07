using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlayer : MonoBehaviour
{
    public bool trig;
    public GameObject tir = null;
    //public GameObject affichePv;
    public int vie;
    public int posTir;

    // Start is called before the first frame update
    void Start()
    {
        tir = null;
        vie = 4;
        //affichePv.GetComponent<Text>().text=vie.ToString();
        posTir = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (true) {
            if((Input.GetKeyDown(KeyCode.RightArrow) && posTir == 2) || (Input.GetKeyDown(KeyCode.LeftArrow) && posTir == 1)) {
                Destroy(tir);
                if (vie < 4) {
                    vie++;
                }
            }
        }
        //affichePv.GetComponent<Text>().text=vie.ToString();
    }

    void OnCollisionEnter2D(Collision2D collider){
        if (collider.gameObject.tag == "tir") {
            Destroy(collider.gameObject);
            vie--;
            if (vie == 0) {
                Time.timeScale = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider){
        if (collider.gameObject.tag == "tir") {
            if(collider.gameObject.transform.position.x < 0) {
                posTir = 1;
            }else
            {
                posTir = 2;
            }
            trig = true;
            tir = collider.gameObject;
        }
    }
}
