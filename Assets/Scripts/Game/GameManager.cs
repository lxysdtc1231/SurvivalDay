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
        Player.PlayerSpawn(BornPoint);
        

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
        Player.LoadPlayerInfo();
        
       
    }


}
