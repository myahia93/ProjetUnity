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
        if (trig) {
            if((Input.GetKeyDown(KeyCode.RightArrow) && posTir == 2) || (Input.GetKeyDown(KeyCode.LeftArrow) && posTir == 1)) {
                Destroy(tir);
                if (vie < 4) {
                    vie++;
                    positionApresImpact(vie, posTir);
                    trig = false;
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
                //Time.timeScale = 0;
                GetComponent<Rigidbody2D>().gravityScale = 1;
            }else {
                positionApresImpact(vie, posTir);
                trig = false;
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

    void positionApresImpact(int vie, int direction) {
        switch (vie)
        {
            case 1:
                if (direction == 1) {
                    transform.position = new Vector2(5,1.3f);
                    transform.rotation = Quaternion.Euler(0, 0, -60);
                }else {
                    transform.position = new Vector2(-5,1.3f);
                    transform.rotation = Quaternion.Euler(0, 0, 60);
                }
                break;
            case 2:
                if (direction == 1) {
                    transform.position = new Vector2(4,2.0f);
                    transform.rotation = Quaternion.Euler(0, 0, -45);
                }else {
                    transform.position = new Vector2(-4,2.0f);
                    transform.rotation = Quaternion.Euler(0, 0, 45);
                }
                break;
            case 3:
                if (direction == 1) {
                    transform.position = new Vector2(2,2.5f);
                    transform.rotation = Quaternion.Euler(0, 0, -25);
                }else {
                    transform.position = new Vector2(-2,2.5f);
                    transform.rotation = Quaternion.Euler(0, 0, 25);
                }
                break;
            case 4:
                transform.position = new Vector2(0,2.4f);
                transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            default:
                break;
        }
    }
}
