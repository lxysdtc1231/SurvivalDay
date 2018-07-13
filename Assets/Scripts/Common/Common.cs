using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common : MonoBehaviour
{
    public static void GrassSpawn(GameObject GrassLand,float i,float j,GameObject Group)
    {
        //放到组里
        //  GameObject MapBlock_Grass = new GameObject("MapBlock_Grass");
       
        Instantiate(GrassLand, new Vector3(i, j, 0), Quaternion.identity, Group.transform);
    }
 



}
