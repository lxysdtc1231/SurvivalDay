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
        //读取存档
        LoadSaveInfo();
       
     
        //生成角色
        PlayerSpawn(BornPoint);
        //显示状态
        PanelMgr.instance.OpenPanel<StatuPanel>("");
    }
    void Update () {
    
    }
    void OnDestroy()
    {
       
    }
    #endregion



    //读取存档信息
    public void LoadSaveInfo()
    {
        //读取角色信息
        load = new PlayerInfo();
#if UNITY_EDITOR

        load = IOHelper.LoadPlayer();
#else
        load=IOHelper.LoadPlayerAndroid();
#endif
        //出生点赋值
        BornPoint = new Vector2(load.Pos_X, load.Pos_Y);

        // 读取世界信息
        // World.LoadWorldInfo();
    }


   

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
    public void PlayerSpawn(Vector2 pos)
    {
        
        GameObject playermodel = Resources.Load("Player/MainPlayer") as GameObject;
        Instantiate(playermodel, pos, Quaternion.identity);
    }

    //测试加血
    public void HPAdd()
    {
        Player.MainPlayerInfo.HP +=10;
    }
}
