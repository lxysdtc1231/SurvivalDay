using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginPanel : PanelBase
{
    public string PlayerName;
    //UI
    private Button btn_plaer1;
    private InputField input_name;
    public InputField input_ip;

    #region 生命周期
    //初始化
    public override void Init(params object[] args)
    {
        base.Init(args);
        skinPath = "LoginPanel";
        layer = PanelLayer.Panel;
    }

    public override void OnShowing()
    {
        base.OnShowing();
        Transform skinTrans = skin.transform;
        btn_plaer1 = skinTrans.Find("Btn_1P").GetComponent<Button>();
        input_name = skinTrans.Find("Input_name").GetComponent<InputField>();
        input_ip = skinTrans.Find("Input_ip").GetComponent<InputField>();
    }
    #endregion
  
    

}