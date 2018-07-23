using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;
using Assets.Scripts.Player;
using System.Runtime.Serialization.Formatters.Binary;

public class IOHelper : MonoBehaviour {
    public PlayerList playerList = new PlayerList();

     void Start()
    {
        PlayerInfo myplayer = new PlayerInfo();
        myplayer.PlayerID = 1;
        myplayer.PlayerName = "Dawn";
        myplayer.Level = 1;
        myplayer.HP = 100;
        myplayer.Starvation = 200;
        myplayer.Thirsty = 200;
        myplayer.Attack = 10;
        myplayer.Defenses = 10;

        Save(myplayer);
        Debug.Log(LoadJsonFromFile().PlayerName);
    }

    public void Save(PlayerInfo player)
    {
        //打包后Resources文件夹不能存储文件，如需打包后使用自行更换目录
        string filePath = Application.dataPath + @"/AssetBundle/JsonPlayer.json";
        Debug.Log(Application.dataPath + @"/AssetBundle/JsonPlayer.json");

        if (!File.Exists(filePath))  //不存在就创建键值对
        {
            playerList.dictionary.Add("PlayerID", player.PlayerID.ToString());
            playerList.dictionary.Add("PlayerName", player.PlayerName);
            playerList.dictionary.Add("Level", player.Level.ToString());
            playerList.dictionary.Add("HP", player.HP.ToString());
            playerList.dictionary.Add("Starvation", player.Starvation.ToString());
            playerList.dictionary.Add("Thirsty", player.Thirsty.ToString());
            playerList.dictionary.Add("Attack", player.Attack.ToString());
            playerList.dictionary.Add("Defenses", player.Defenses.ToString());
        }
        else   //若存在就更新值
        {
            playerList.dictionary["PlayerID"] = player.PlayerID.ToString();
            playerList.dictionary["PlayerName"] = player.PlayerName;
            playerList.dictionary["Level"] = player.Level.ToString();
            playerList.dictionary["HP"] = player.HP.ToString();
            playerList.dictionary["Starvation"] = player.Starvation.ToString();
            playerList.dictionary["Thirsty"] = player.Thirsty.ToString();
            playerList.dictionary["Attack"] = player.Attack.ToString();
            playerList.dictionary["Defenses"] = player.Defenses.ToString();
        }

        //找到当前路径
        FileInfo file = new FileInfo(filePath);
        //判断有没有文件，有则打开文件，，没有创建后打开文件
        StreamWriter sw = file.CreateText();
        //ToJson接口将你的列表类传进去，，并自动转换为string类型
        string json = JsonMapper.ToJson(playerList.dictionary);
        //将转换好的字符串存进文件，
        sw.WriteLine(json);
        //注意释放资源
        sw.Close();
        sw.Dispose();

        UnityEditor.AssetDatabase.Refresh();

    }
    /// <summary>
    /// 读取保存数据的方法
    /// </summary>
    public void LoadPlayer()
    {
        //TextAsset该类是用来读取配置文件的
        string path = "JsonPlayer";
        TextAsset asset = Resources.Load("JsonPlayer") as TextAsset;
      

        if (!asset)  //读不到就退出此方法
            return;

        string strdata = asset.text;
        JsonData jsdata3 = JsonMapper.ToObject(strdata);
        //在这里循环输出表示读到了数据，，即此数据可以使用了
        for (int i = 0; i < jsdata3.Count; i++)
        {
            Debug.Log(jsdata3[i]);
        }
        //使用foreach输出的话会以[键，值]，，，
        /*foreach (var item in jsdata3)
        {
            Debug.Log(item);
        }*/

    }

    public static PlayerInfo LoadJsonFromFile()
    {
        BinaryFormatter bf = new BinaryFormatter();

        if (!File.Exists(Application.dataPath + "/Data/JsonPlayer.json"))
        {
            Debug.Log("读取为空");
            return null;
        }

        StreamReader sr = new StreamReader(Application.dataPath + "/Data/JsonPlayer.json");

        //FileStream file = File.Open(Application.dataPath + "/Test.json", FileMode.Open, FileAccess.ReadWrite);
        //if (file.Length == 0)
        //{
        //    return null;
        //}

        //string json = (string)bf.Deserialize(file);
        //file.Close();

        if (sr == null)
        {
            Debug.Log("111");
            return null;
        }
        string json = sr.ReadToEnd();

        if (json.Length > 0)
        {
            return JsonUtility.FromJson<PlayerInfo>(json);
        }

        return null;
    }
}
