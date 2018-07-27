using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour {
    public GameObject player;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //虚拟键盘连接控制器
    //向上
    public void BtnUp_Down()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        player.GetComponent<PlayerController>().BtnUp_Down();
    }
    public void BtnUp_Up()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        player.GetComponent<PlayerController>().BtnUp_Up();
    }

    //向下
    public void BtnDown_Down()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        player.GetComponent<PlayerController>().BtnDown_Down();
    }
    public void BtnDown_Up()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        player.GetComponent<PlayerController>().BtnDown_Up();
    }

    //向左
    public void BtnLeft_Down()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        player.GetComponent<PlayerController>().BtnLeft_Down();
    }
    public void BtnLeft_Up()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        player.GetComponent<PlayerController>().BtnLeft_Up();
    }
    
    //向右
    public void BtnRight_Down()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        player.GetComponent<PlayerController>().BtnRight_Down();
    }
    public void BtnRight_Up()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        player.GetComponent<PlayerController>().BtnRight_Up();
    }

    public void OnClickExit()
    {

        Save();
        Application.Quit();
    }

    public void Save()
    {
        //数据同步
        GameObject.FindWithTag("Player").GetComponent<Player>().MainPlayerInfo.Pos_X = GameObject.FindWithTag("Player").transform.position.x;
        GameObject.FindWithTag("Player").GetComponent<Player>().MainPlayerInfo.Pos_Y = GameObject.FindWithTag("Player").transform.position.y;
        //写入本地文件
        IOHelper.Save(GameObject.FindWithTag("Player").GetComponent<Player>().MainPlayerInfo);
    }
}
