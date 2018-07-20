using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //移动速度
    public float MoveSpeed = 10;
    float x;
    float y;
    void Update()
    {
        //float x = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
        //float y = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        transform.Translate(x, y, 0);

        if (Input.GetKey(KeyCode.S) && gameObject.GetComponent<Animator>().GetInteger("Walk") == 0)
        {
            gameObject.GetComponent<Animator>().SetInteger("Walk", 2);
           gameObject.GetComponent<Animator>().SetBool("Idle",false);
            y = -MoveSpeed * Time.deltaTime;
        }


        if (Input.GetKeyUp(KeyCode.S)&& gameObject.GetComponent<Animator>().GetInteger("Walk") == 2)
        {
      
            gameObject.GetComponent<Animator>().SetBool("Idle", true);
            y = 0;
            gameObject.GetComponent<Animator>().SetInteger("Walk", 0);
        }

     

        if (Input.GetKey(KeyCode.W) && gameObject.GetComponent<Animator>().GetInteger("Walk") == 0)
        {
            gameObject.GetComponent<Animator>().SetInteger("Walk", 1);
            gameObject.GetComponent<Animator>().SetBool("Idle", false);
            y = MoveSpeed * Time.deltaTime;
        }


        if (Input.GetKeyUp(KeyCode.W) && gameObject.GetComponent<Animator>().GetInteger("Walk") == 1)
        {
           
            gameObject.GetComponent<Animator>().SetBool("Idle", true);
            y = 0;
            gameObject.GetComponent<Animator>().SetInteger("Walk", 0);
        }

     

        if (Input.GetKey(KeyCode.A) && gameObject.GetComponent<Animator>().GetInteger("Walk") == 0)
        {
            gameObject.GetComponent<Animator>().SetInteger("Walk", 3);
            gameObject.GetComponent<Animator>().SetBool("Idle", false);
            x = -MoveSpeed * Time.deltaTime;
        }


        if (Input.GetKeyUp(KeyCode.A) && gameObject.GetComponent<Animator>().GetInteger("Walk") == 3)
        {
        
            gameObject.GetComponent<Animator>().SetBool("Idle", true);
            x = 0;
            gameObject.GetComponent<Animator>().SetInteger("Walk", 0);
        }

        if (Input.GetKey(KeyCode.D) && gameObject.GetComponent<Animator>().GetInteger("Walk") == 0)
        {
            gameObject.GetComponent<Animator>().SetInteger("Walk", 4);
            gameObject.GetComponent<Animator>().SetBool("Idle", false);
            x = MoveSpeed * Time.deltaTime;
        }


        if (Input.GetKeyUp(KeyCode.D) && gameObject.GetComponent<Animator>().GetInteger("Walk") == 4)
        {
         
            gameObject.GetComponent<Animator>().SetBool("Idle", true);
            x = 0;
            gameObject.GetComponent<Animator>().SetInteger("Walk", 0);
        }

        
    }
}
