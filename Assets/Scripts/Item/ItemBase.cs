using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 物品基类
/// </summary>
public class ItemBase  {

    //物品编号
    public int ItemID;
   //类别
    public int type;
    //数量 
    public int Item_Count;
    //物品类型  装备 武器 食物 消耗品 材料
    enum Item
    {
        equipment=10,
        Weapon=20,
        food=30,
        Consumable= 40,
        material=50
    }

    public static void ItemSave()
    {


    }

    public static void ItemLoad()
    {

    }






   
   
    



}
