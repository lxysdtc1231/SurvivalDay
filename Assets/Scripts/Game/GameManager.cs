using Assets.Scripts.Item;
using Assets.Scripts.Player;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public Vector2 BornPoint;
    public PlayerInfo load;
 
    // Use this for ini1tialization
    #region 生命周期
    void Awake()
    {
 
    }
    void Start ()
    {       
        //生成角色
        PlayerSpawn();
        //显示状态板
        if (GameObject.FindWithTag("Player").GetComponent<Player>().MainPlayerInfo != null)
        {
            //显示状态
            PanelMgr.instance.OpenPanel<StatuPanel>("");
        }
        IOHelper.LoadItmeInfo();
       
       
    }
    void Update () {
    
    }
    void OnDestroy()
    {
       
    }
    #endregion



//    //读取存档信息
//    public void LoadSaveInfo()
//    {
//        //读取角色信息
//        load = new PlayerInfo();
//#if UNITY_EDITOR

//        load = IOHelper.LoadPlayer();
//#else
//        load=IOHelper.LoadPlayerAndroid();
//#endif
//        //出生点赋值
//        BornPoint = new Vector2(load.Pos_X, load.Pos_Y);

//        // 读取世界信息
//        // World.LoadWorldInfo();
//    }


   

    //背包点击事件
    public void OnPackageClick()
    {
        if (GameObject.Find("GameManager").GetComponent<PanelMgr>().dict.ContainsKey("BagPackagePanel"))
        {
            PanelMgr.instance.ClosePanel("BagPackagePanel");
        }

        PanelMgr.instance.OpenPanel<BagPackagePanel>("");
        //  Debug.Log(GameObject.Find("GameManager").GetComponent<PanelMgr>().dict);
    }

    //角色生成器
    public void PlayerSpawn()
    {
        
        GameObject playermodel = Resources.Load("Player/MainPlayer") as GameObject;
        //读取角色位置信息
        Vector2 bornpoint = new Vector2(IOHelper.LoadPlayerInfo().Pos_X, IOHelper.LoadPlayerInfo().Pos_Y);
        Instantiate(playermodel,bornpoint, Quaternion.identity);
    }

    //测试加血
    public void HPAdd()
    {
       
    }
}
