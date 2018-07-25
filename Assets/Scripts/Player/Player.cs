using Assets.Scripts.Player;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 玩家类
/// </summary>
/// 

public class Player : MonoBehaviour {

    //角色信息
   
    public static PlayerInfo MainPlayerInfo;
    void Start()
    {
        //加载角色数据
        //  MainPlayerInfo= LoadPlayerInfo();
        MainPlayerInfo = GameObject.Find("GameManager").GetComponent<GameManager>().load;
    }

    void Update()
    {

     
    }

     void OnDestroy()
    {
        //数据同步
        MainPlayerInfo.Pos_X =gameObject.transform.position.x;
        MainPlayerInfo.Pos_Y =gameObject.transform.position.y;
        //写入本地文件
        IOHelper.Save(MainPlayerInfo);
    }




    //玩家掉血
    public static void HPDecrease(int value)
    {
       MainPlayerInfo.HP =MainPlayerInfo.HP - value;
    }

  
}
