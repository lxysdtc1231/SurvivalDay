using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Player
{
  public class PlayerInfo
    {
        //角色ID
        public int PlayerID { get; set; }

        //角色昵称
        public string PlayerName { get; set; }

        //角色等级
        public int Level { get; set; }

        //角色HP
        public int HP { get; set; }

        //角色饱腹值
        public int Starvation { get; set; }

        //角色口渴值
        public int Thirsty { get; set; }

        //角色攻击力
        public int Attack { get; set; }

        //角色防御力
        public int Defenses { get; set; }
      

    }
}
