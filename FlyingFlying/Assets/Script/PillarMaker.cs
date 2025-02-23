﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarMaker : MonoBehaviour
{

    public GameObject Colum;

    private float nowTime;
    private float makeTime = 2f;


    // Start is called before the first frame update
    void Start()
    {
        nowTime = Time.time;        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - nowTime > makeTime)
        {
            nowTime = Time.time;
            GameObject temp = Instantiate(Colum);
            temp.transform.parent = gameObject.transform;

            float randomY = Random.Range(-0.4f, 1.3f);

            temp.transform.localPosition = new Vector3(-gameObject.transform.localPosition.x + 5, randomY, 0);
            temp.transform.localScale = new Vector3(1, 1, 1);
        }
        
    }
}
