﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Item
{
   public class FoodInfo:ItemInfo
    {

        //饱腹度增加值
        public int StarStarvation { get; set; }

        //口渴值增加
        public int Thirsty { get; set; }

        //状态
        public int State { get; set; }


        //描述
        public string Describe { get; set; }



    }
}
