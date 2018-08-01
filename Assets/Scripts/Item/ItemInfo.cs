using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Item
{
    public class ItemInfo
    {
        //物品编号
        public int ItemID {get;set;}

        //物品名称
        public string ItemName { get; set; }

        //物品类型
        public int ItmeType { get; set; }

        public enum Type
        {
          Food,
          Equi,
          Material,
          Weapon

        }







    }
}
