using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{

    public GameObject[] grounds;
    ButtonControl startbutton = GameObject.Find("StartButton").GetComponent<ButtonControl>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 0 || startbutton.gamestart == false)
        {
            return;
        }

        gameObject.transform.localPosition += new Vector3(-0.05f, 0, 0);
        if(gameObject.transform.localPosition.x <= -11)
        {
            gameObject.transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}
