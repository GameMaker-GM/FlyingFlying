using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdContorl : MonoBehaviour
{
    ButtonControl startbutton = GameObject.Find("StartButton").GetComponent<ButtonControl>();

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(480, 800, false);
    }

    // Update is called once per frame
    void Update()
    {
        if (startbutton.gamestart == true)
        {
            Rigidbody gameObjectsRigidBody = gameObject.AddComponent<Rigidbody>();
            gameObjectsRigidBody.mass = 1;
        }

            if (Input.GetMouseButtonDown(0))
        {
            //적용되어 있는 vector값 초기화
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            //Y값 더해주기 
            gameObject.GetComponent<Rigidbody>().AddForce(0, 300, 0);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Game");
           
        }
    }

    void OnCollisionEnter(Collision coll)
    {

        //Debug.Log("GameOver");
        //gameover 후에는 timeScale이 0이기 때문에 클릭 이벤트가 발생해도 점프하지 않는다
        Time.timeScale = 0;
        gameObject.GetComponent<Animator>().Play("Die");
    }
}