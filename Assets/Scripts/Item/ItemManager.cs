using Assets.Scripts.Item;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private Dictionary<int, FoodInfo> ItemInfoDict_Food = new Dictionary<int, FoodInfo>();

    public enum ItemType
    {
        Food,//食物
        Equip,//装备
        Mat//材料
    }


}
