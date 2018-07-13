using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class MapMaker  {
    public static int rows;
    public static int cols;
    public static UnityEngine.Object GrassLand_O;
    public static UnityEngine.GameObject GrassLand;
    [MenuItem("Assets/MapMaker/GrassFloorSpawn")]
    public static void GrassFloorSpawn()
    {
        rows = 10;
        cols = 10;
        GrassLand=  (Resources.Load("Floor/GrassLand", typeof(GameObject)))as GameObject;
        //GrassLand = GrassLand_O;
        //  GameObject MapBlock_Grass = new GameObject("MapBlock_Grass");
        GameObject map = new GameObject("Grass");
        Vector2 BornPoint = new Vector2(0, 0);

        for (int i = Convert.ToInt32(BornPoint.x); i < Convert.ToInt32(BornPoint.y) + rows; i++)
        {

            for (int j = Convert.ToInt32(BornPoint.y); j < Convert.ToInt32(BornPoint.y) + cols; j++)
            {
                ////如果是边界
                //if (i == 0 || j == 0 || i == Convert.ToInt32(BornPoint.x) + rows || j == Convert.ToInt32(BornPoint.y + cols))
                //{
                //    //UnityEngine.Object goLand = Resources.Load("Floor/BoardLand", typeof(GameObject));
                //    // mapland.Add(GameObject.Instantiate(goLand, new Vector3(i, j, 0), Quaternion.identity,Map.transform) as GameObject);
                //    Debug.Log(i);
                //    Debug.Log(j);
                //    continue;
                //}
                //生成草地

                Common.GrassSpawn(GrassLand, i, j,map);
                //Instantiate(GrassLand, new Vector3(i, j, 0), Quaternion.identity, MapBlock_Grass.transform);

            }

        }


    }
    [MenuItem("Assets/MapMaker/SeaFloorSpawn")]
    public static void LakeFloorSpawn()
    {
        rows = 10;
        cols = 10;
        GrassLand = (Resources.Load("Floor/LakeLand", typeof(GameObject))) as GameObject;
        //GrassLand = GrassLand_O;
        //  GameObject MapBlock_Grass = new GameObject("MapBlock_Grass");
        GameObject map = new GameObject("Lake");
        Vector2 BornPoint = new Vector2(0, 0);

        for (int i = Convert.ToInt32(BornPoint.x); i < Convert.ToInt32(BornPoint.y) + rows; i++)
        {

            for (int j = Convert.ToInt32(BornPoint.y); j < Convert.ToInt32(BornPoint.y) + cols; j++)
            {
                ////如果是边界
                //if (i == 0 || j == 0 || i == Convert.ToInt32(BornPoint.x) + rows || j == Convert.ToInt32(BornPoint.y + cols))
                //{
                //    //UnityEngine.Object goLand = Resources.Load("Floor/BoardLand", typeof(GameObject));
                //    // mapland.Add(GameObject.Instantiate(goLand, new Vector3(i, j, 0), Quaternion.identity,Map.transform) as GameObject);
                //    Debug.Log(i);
                //    Debug.Log(j);
                //    continue;
                //}
                //生成草地

                Common.GrassSpawn(GrassLand, i, j, map);
                //Instantiate(GrassLand, new Vector3(i, j, 0), Quaternion.identity, MapBlock_Grass.transform);

            }

        }


    }
}
