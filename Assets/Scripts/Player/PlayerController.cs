using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    //移动速度
    public float MoveSpeed=10;
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        transform.Translate(x, y, 0);
    }

   
}
