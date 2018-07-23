using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public Vector2 BornPoint;
	// Use this for ini1tialization
	void Start () {
        BornPoint = new Vector2(0, 0);

        //读取存档信息
        LoadSaveInfo();
        //生成角色
        PlayerSpawn(BornPoint);
        //显示状态
        PanelMgr.instance.OpenPanel<StatuPanel>("");

    }

    // Update is called once per frame
    void Update () {
    
    }
    //读取存档信息
    public void LoadSaveInfo()
    {
        // 读取世界信息
        World.LoadWorldInfo();
        // 读取角色信息
       // Player.LoadPlayerInfo();
        
       
    }

    //背包点击事件
    public void OnPackageClick()
    {
      PanelMgr.instance.OpenPanel<BagPackagePanel>("");
    }
    public void OnPackageExit()
    {

    }

    //角色生成器
    public void PlayerSpawn(Vector2 pos)
    {
        GameObject playermodel = Resources.Load("Player/MainPlayer") as GameObject;
        Instantiate(playermodel, pos, Quaternion.identity);
    }
}
