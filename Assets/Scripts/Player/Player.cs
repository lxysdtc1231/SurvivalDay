using Assets.Scripts.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 玩家类
/// </summary>
public class Player : MonoBehaviour {
  
    //角色ID
    public  static int PlayerID;
    //角色昵称
    public static  string PlayerName;
    //角色等级
    public static int Level;
    //角色血量
    public static int HP;
    //角色饱腹度
    public static  int Starvation;
    //口渴度
    public static int Thirsty;
    //攻击力
    public static int Attack;
    //防御值
    public static int Defenses;
    //存储读取的角色数据
    public PlayerInfo playerinfo;
    void Start()
    {
        //加载角色数据
        playerinfo = LoadPlayerInfo();
        //角色数据赋值
        PlayerID = playerinfo.PlayerID;
        PlayerName = playerinfo.PlayerName;
        Level = playerinfo.Level;
        HP = playerinfo.HP;
        Starvation = playerinfo.Starvation;
        Thirsty = playerinfo.Thirsty;
        Attack = playerinfo.Attack;
        Defenses = playerinfo.Defenses;

    }


    //加载角色数据
    public PlayerInfo LoadPlayerInfo()
    {
        PlayerInfo get = new PlayerInfo();
        get.PlayerID = 1;
        get.PlayerName = "Dawn";
        get.Level = 1;
        get.HP = 100;
        get.Starvation = 200;
        get.Thirsty = 200;
        get.Attack = 10;
        get.Defenses = 10;
        return get;
    
    }


    //保存角色数据
    public static void SavePlayerInfo()
    {

    }



  
}
