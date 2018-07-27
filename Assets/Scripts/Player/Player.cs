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
    public PlayerInfo MainPlayerInfo;

    void Awake()
    {
        //加载角色数据
        MainPlayerInfo = IOHelper.LoadPlayerInfo();

    }
    void Start()
    {
       
        
    }
    void Update()
    {

     
    }
    void OnDestroy()
    {
    }

    //玩家掉血
    public  void HPDecrease(int value)
    {
       MainPlayerInfo.HP =MainPlayerInfo.HP - value;
    }

  
}
