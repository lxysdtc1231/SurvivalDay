using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 玩家类
/// </summary>
public class Player : MonoBehaviour {
  
    //角色ID
    public int PlayerID;
    //角色昵称
    public string PlayerName;
    
    /// <summary>
    /// 角色生成器
    /// 作者：Dawn
    /// </summary>
    ///<param name= PlayerID">角色ID</param>
    ///<param name="pos">生成位置</param>
    public static void PlayerSpawn(Vector2 pos)
    {
        GameObject player = Resources.Load("Player/MainPlayer") as GameObject;
        Instantiate(player, pos, Quaternion.identity);
    }

    /// <summary>
    /// 从外部读取角色信息
    /// 作者：
    /// </summary>
    ///<param name= ""></param>
    ///<param name=""></param>
    public static void LoadPlayerInfo()
    {


    }


    /// <summary>
    /// 保存角色信息并导出外部文件
    /// 作者：
    /// </summary>
    ///<param name= ""></param>
    ///<param name=""></param>
    ///<returns></returns>
    public static void SavePlayerInfo()
    {

    }

  
}
