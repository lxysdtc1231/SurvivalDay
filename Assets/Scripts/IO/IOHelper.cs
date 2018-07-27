using UnityEngine;
using System.IO;
using LitJson;
using Assets.Scripts.Player;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.UI;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using Assets.Scripts.Item;

public class IOHelper : MonoBehaviour
{
    public static PlayerInfoList playerList = new PlayerInfoList();

    void Awake()
    {

        CreatePlayer();

    }
    void Start()
    {

        //   Save(myplayer);
        //   LoadPlayer();
    }
    //创建新玩家
    public static void CreatePlayer()
    {

        //   string filePath = Application.dataPath + @"/StreamingAssets/JsonPlayer.json";
#if UNITY_EDITOR
        
        string filepath = Application.persistentDataPath + "/JsonPlayer.json";

#elif UNITY_ANDROID
       string filepath=Application.persistentDataPath + "/JsonPlayer.json";
#endif
        if (!File.Exists(filepath))
        {
         //   GameObject.Find("Test").GetComponent<Text>().text = filepath;
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
            FileInfo file = new FileInfo(filepath);

            //判断有没有文件，有则打开文件，，没有创建后打开文件
            StreamWriter sw = file.CreateText();
            //ToJson接口将你的列表类传进去，，并自动转换为string类型
            //string json = Encryption.Encrypt(JsonMapper.ToJson(playerList.dictionary));
            string json = JsonMapper.ToJson(playerList.dictionary);
            //将转换好的字符串存进文件，
            sw.WriteLine(json);
            //注意释放资源
            sw.Close();
            sw.Dispose();
            

        }
        else {
            return;
        }
           
       
    }
    /// <summary>
    /// 保存玩家数据的方法
    /// </summary>
    public static void Save(PlayerInfo player)
    {
#if UNITY_EDITOR ||UNITY_WIN
        SaveWin(player);
#elif UNITY_ANDROID
        SaveAndroid(player);
#endif

    }
    public static void SaveWin(PlayerInfo player)
    {
        string filepath =Application.persistentDataPath + "/JsonPlayer.json";
        try
        {
            if (!File.Exists(filepath))  //不存在就创建键值对
            {
                playerList.dictionary.Add("PlayerID", player.PlayerID.ToString());
                playerList.dictionary.Add("PlayerName", player.PlayerName);
                playerList.dictionary.Add("Level", player.Level.ToString());
                playerList.dictionary.Add("HP", player.HP.ToString());
                playerList.dictionary.Add("Starvation", player.Starvation.ToString());
                playerList.dictionary.Add("Thirsty", player.Thirsty.ToString());
                playerList.dictionary.Add("Attack", player.Attack.ToString());
                playerList.dictionary.Add("Defenses", player.Defenses.ToString());
                playerList.dictionary.Add("Pos_X", player.Pos_X.ToString());
                playerList.dictionary.Add("Pos_Y", player.Pos_Y.ToString());
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
                playerList.dictionary["Pos_X"] = player.Pos_X.ToString();
                playerList.dictionary["Pos_Y"] = player.Pos_Y.ToString();
                Debug.Log("数据更新" + "" + player.Pos_X.ToString() + "" + player.Pos_Y.ToString());
            }
            //找到当前路径
            FileInfo file = new FileInfo(filepath);

            //判断有没有文件，有则打开文件，，没有创建后打开文件
            StreamWriter sw = file.CreateText();
            //ToJson接口将你的列表类传进去，，并自动转换为string类型
            // string json = Encryption.Encrypt(JsonMapper.ToJson(playerList.dictionary));
            string json = JsonMapper.ToJson(playerList.dictionary);
            //将转换好的字符串存进文件，
            sw.WriteLine(json);


            //注意释放资源
            sw.Close();
            sw.Dispose();

#if UNITY_EDITOR
            UnityEditor.AssetDatabase.Refresh();
#endif
          
            Debug.Log("保存数据成功");
        }

        catch (Exception e) {
       

        }
       
        
    }
    public static void SaveAndroid(PlayerInfo player)
    {
       string filepath=Application.persistentDataPath + "/JsonPlayer.json";

        try
        {
            if (!File.Exists(filepath))  //不存在就创建键值对
            {
                playerList.dictionary.Add("PlayerID", player.PlayerID.ToString());
                playerList.dictionary.Add("PlayerName", player.PlayerName);
                playerList.dictionary.Add("Level", player.Level.ToString());
                playerList.dictionary.Add("HP", player.HP.ToString());
                playerList.dictionary.Add("Starvation", player.Starvation.ToString());
                playerList.dictionary.Add("Thirsty", player.Thirsty.ToString());
                playerList.dictionary.Add("Attack", player.Attack.ToString());
                playerList.dictionary.Add("Defenses", player.Defenses.ToString());
                playerList.dictionary.Add("Pos_X", player.Pos_X.ToString());
                playerList.dictionary.Add("Pos_Y", player.Pos_Y.ToString());
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
                playerList.dictionary["Pos_X"] = player.Pos_X.ToString();
                playerList.dictionary["Pos_Y"] = player.Pos_Y.ToString();
                Debug.Log("数据更新" + "" + player.Pos_X.ToString() + "" + player.Pos_Y.ToString());

            }

            //找到当前路径
            FileInfo file = new FileInfo(filepath);

            //判断有没有文件，有则打开文件，，没有创建后打开文件
            StreamWriter sw = file.CreateText();
            //ToJson接口将你的列表类传进去，，并自动转换为string类型
            //string json = Encryption.Encrypt(JsonMapper.ToJson(playerList.dictionary));
            string json = JsonMapper.ToJson(playerList.dictionary);
            //将转换好的字符串存进文件，
            sw.WriteLine(json);
            //注意释放资源
            sw.Close();
            sw.Dispose();

#if UNITY_EDITOR
            UnityEditor.AssetDatabase.Refresh();
#endif
            Debug.Log("保存数据成功");
        }

        catch (Exception e)
        {

        }
    }
    /// <summary>
    /// 读取保存数据的方法
    /// </summary>
    public static PlayerInfo LoadPlayerInfo()
    {
#if UNITY_EDITOR||UNITY_WIN
        return LoadPlayerWin();
#else
        return LoadPlayerAndroid();
#endif
    }
    public static PlayerInfo LoadPlayerWin()
    {    
        PlayerInfo loadinfo = new PlayerInfo();   
        //人物信息读取路径   
        string filePath = Application.persistentDataPath + "/JsonPlayer.json";
        Debug.Log(filePath);
        //如果存在存档
        if (File.Exists(filePath))
        {
            StreamReader sr = new StreamReader(filePath);
            //string jsonStr = Encryption.Decrypt(sr.ReadToEnd());
            string jsonStr = sr.ReadToEnd();
            sr.Close();

            JsonData jsdata3 = JsonMapper.ToObject(jsonStr);
            for (int i = 0; i < jsdata3.Count; i++)
            {
                Debug.Log(jsdata3[i]);
                if (i == 0)
                    loadinfo.PlayerID = int.Parse(jsdata3[i].ToString());
                else if (i == 1)
                    loadinfo.PlayerName = jsdata3[i].ToString();
                else if (i == 2)
                    loadinfo.Level = int.Parse(jsdata3[i].ToString());
                else if (i == 3)
                    loadinfo.HP = int.Parse(jsdata3[i].ToString());
                else if (i == 4)
                    loadinfo.Starvation = int.Parse(jsdata3[i].ToString());
                else if (i == 5)
                    loadinfo.Thirsty = int.Parse(jsdata3[i].ToString());
                else if (i == 6)
                    loadinfo.Attack = int.Parse(jsdata3[i].ToString());
                else if (i == 7)
                    loadinfo.Defenses = int.Parse(jsdata3[i].ToString());
                else if (i == 8)
                    loadinfo.Pos_X = float.Parse(jsdata3[i].ToString());
                else if (i == 9)
                    loadinfo.Pos_Y = float.Parse(jsdata3[i].ToString());
            }
            Debug.Log(jsonStr);
            return loadinfo;
        }
        //如果存档不存在
        else
        {
            Debug.Log("存档读取失败");
            return null;
        }
    }
    public static PlayerInfo LoadPlayerAndroid()
    {
        
        PlayerInfo loadinfo = new PlayerInfo();
        //string jsonStr =  Encryption.Decrypt(GetJson("/JsonPlayer.json"));
        string jsonStr = GetJson("/JsonPlayer.json");

        JsonData jsdata3 = JsonMapper.ToObject(jsonStr);
        for (int i = 0; i < jsdata3.Count; i++)
        {
            Debug.Log(jsdata3[i]);
            if (i == 0)
                loadinfo.PlayerID = int.Parse(jsdata3[i].ToString());
            else if (i == 1)
                loadinfo.PlayerName = jsdata3[i].ToString();
            else if (i == 2)
                loadinfo.Level = int.Parse(jsdata3[i].ToString());
            else if (i == 3)
                loadinfo.HP = int.Parse(jsdata3[i].ToString());
            else if (i == 4)
                loadinfo.Starvation = int.Parse(jsdata3[i].ToString());
            else if (i == 5)
                loadinfo.Thirsty = int.Parse(jsdata3[i].ToString());
            else if (i == 6)
                loadinfo.Attack = int.Parse(jsdata3[i].ToString());
            else if (i == 7)
                loadinfo.Defenses = int.Parse(jsdata3[i].ToString());
            else if (i == 8)
                loadinfo.Pos_X = float.Parse(jsdata3[i].ToString());
            else if (i == 9)
                loadinfo.Pos_Y = float.Parse(jsdata3[i].ToString());
        }
        Debug.Log(jsonStr);
        return loadinfo;
    }

    /// <summary>
    /// 读取食物数据的方法
    /// </summary>
    public static FoodInfo LoadItmeInfo()
    {
        FoodInfo foodInfo = new FoodInfo();
        //食品信息读取路径   
        string filePath = Application.streamingAssetsPath + "/JsonFood.json";
        string jsonStr = GetJsonByWWW("/JsonFood.json");
        JsonData jsdata3 = JsonMapper.ToObject(jsonStr);
        for (int i = 0; i < jsdata3.Count; i++)
        {
            Debug.Log(jsdata3[i]);
            if (i == 0)
                foodInfo.ItemID = int.Parse(jsdata3[i].ToString());
            else if (i == 1)
                foodInfo.ItemName = jsdata3[i].ToString();
            else if (i == 2)
                foodInfo.ItmeType = int.Parse(jsdata3[i].ToString());
            else if (i == 3)
                foodInfo.StarStarvation = int.Parse(jsdata3[i].ToString());
            else if (i == 4)
                foodInfo.Thirsty = int.Parse(jsdata3[i].ToString());
            else if (i == 5)
                foodInfo.State = int.Parse(jsdata3[i].ToString());
            else if (i == 6)
                foodInfo.Describe= jsdata3[i].ToString();
        }
        Debug.Log(jsonStr);


        return foodInfo;
    }
    //用StreamReader读取Json
    public static string GetJson(string path)
    {
        string localPath = "";
        localPath = Application.persistentDataPath + path;
       
        StreamReader reader = new StreamReader(Application.persistentDataPath + path);
        string jsonData = reader.ReadToEnd();
     
        return jsonData;

    }

    //用WWW从StreamAssets读取Json
    public static string GetJsonByWWW(string path)
    {
        string localPath = "";
        localPath = Application.streamingAssetsPath + path;
        WWW t_WWW = new WWW(localPath);
        Debug.Log("t_WWW.text=  " + t_WWW.text);
        return t_WWW.text;
    }






}