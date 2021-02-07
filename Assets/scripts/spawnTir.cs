using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTir : MonoBehaviour
{
    public GameObject tir;
    public float spawnRate;
    float nextTir;
    float posX;
    int rnd;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = 2;
        nextTir = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTir)
        {
            rnd = Random.Range(1,3);
            if (rnd == 1)
            {
                posX = 28;
            }else
            {
                posX = -28;
            }
            Instantiate(tir, new Vector2(posX,0.4f), Quaternion.identity);
            nextTir = Time.time + spawnRate;
        }
    }
}
