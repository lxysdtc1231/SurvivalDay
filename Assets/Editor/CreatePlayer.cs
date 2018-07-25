using Assets.Scripts.Player;
using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class CreatePlayer : MonoBehaviour {

    public static PlayerInfoList playerList = new PlayerInfoList();
    //创建玩家档案
    [MenuItem("MyTool/PlayerInfoCreate")]
    public static void GrassSpawn()
    {
        //打包后Resources文件夹不能存储文件，如需打包后使用自行更换目录
        string filePath = Application.dataPath + @"/StreamingAssets/JsonPlayer.json";
        playerList.dictionary.Add("PlayerID", "1");
        playerList.dictionary.Add("PlayerName", "Dawn");
        playerList.dictionary.Add("Level", "1");
        playerList.dictionary.Add("HP", "100");
        playerList.dictionary.Add("Starvation", "100");
        playerList.dictionary.Add("Thirsty", "100");
        playerList.dictionary.Add("Attack", "10");
        playerList.dictionary.Add("Defenses", "10");
        playerList.dictionary.Add("Pos_X", "0");
        playerList.dictionary.Add("Pos_Y", "0");
        //找到当前路径
        FileInfo file = new FileInfo(filePath);

        //判断有没有文件，有则打开文件，，没有创建后打开文件
        StreamWriter sw = file.CreateText();
        //ToJson接口将你的列表类传进去，，并自动转换为string类型
        string json = Encryption.Encrypt(JsonMapper.ToJson(playerList.dictionary));

        //将转换好的字符串存进文件，
        sw.WriteLine(json);
        //注意释放资源
        sw.Close();
        sw.Dispose();


    }


}




